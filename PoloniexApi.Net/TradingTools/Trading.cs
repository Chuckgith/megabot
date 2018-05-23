using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Jojatekok.PoloniexAPI.TradingTools
{
    public class Trading : ITrading
    {
        private ApiWebClient ApiWebClient { get; set; }

        internal Trading(ApiWebClient apiWebClient)
        {
            ApiWebClient = apiWebClient;
        }

        public IList<IOrder> GetOpenOrders(CurrencyPair currencyPair)
        {
            var postData = new Dictionary<string, object> {
                { "currencyPair", currencyPair }
            };

            var data = PostData<IList<Order>>("returnOpenOrders", postData);
            return data.Any() ? data.ToList<IOrder>() : new List<IOrder>();
        }

        public AllOrders GetAllOpenOrders()
        {
            var postData = new Dictionary<string, object> {
                { "currencyPair", "all" }
            };

            var data = PostData<AllOrders>("returnOpenOrders", postData);

            return data;      
        }

        public IList<ITrade> GetTrades(CurrencyPair currencyPair, DateTime startTime, DateTime endTime)
        {
            var postData = new Dictionary<string, object> {
                { "currencyPair", currencyPair },
                { "start", Helper.DateTimeToUnixTimeStamp(startTime) },
                { "end", Helper.DateTimeToUnixTimeStamp(endTime) }};

            var data = PostData<IList<Trade>>("returnTradeHistory", postData);
            return data.Any() ? data.ToList<ITrade>() : new List<ITrade>();
        }

        public ulong PostOrder(CurrencyPair currencyPair, OrderType type, double pricePerCoin, double amountQuote)
        {
            try
            {
                var postData = new Dictionary<string, object> {
                { "currencyPair", currencyPair },
                { "rate", pricePerCoin.ToStringNormalized() },
                { "amount", amountQuote.ToStringNormalized() }};

                var data = PostData<JObject>(type.ToStringNormalized(), postData);

                //Debug.WriteLine(string.Format("PostOrder error: {0}", ((Newtonsoft.Json.Linq.JValue)data["error"]) != null ? ((Newtonsoft.Json.Linq.JValue)data["error"]).Value : ""));
                //Debug.WriteLine(string.Format("PostOrder orderNumber: {0}", ((Newtonsoft.Json.Linq.JValue)data["orderNumber"]) != null ? ((Newtonsoft.Json.Linq.JValue)data["orderNumber"]).Value : ""));

                return data.Value<ulong>("orderNumber");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ulong MoveOrder(CurrencyPair currencyPair, ulong orderId, double pricePerCoin, double amountQuote)
        {
            try
            {
                var postData = new Dictionary<string, object> {
                { "currencyPair", currencyPair },
                { "orderNumber", orderId },
                { "rate", pricePerCoin.ToStringNormalized() },
                { "amount", amountQuote.ToStringNormalized() }};

                var data = PostData<JObject>("moveOrder", postData);

                //Debug.WriteLine(string.Format("MoveOrder error: {0}", ((Newtonsoft.Json.Linq.JValue)data["error"]) != null ? ((Newtonsoft.Json.Linq.JValue)data["error"]).Value : ""));
                //Debug.WriteLine(string.Format("MoveOrder success: {0}", ((Newtonsoft.Json.Linq.JValue)data["success"]) != null ? ((Newtonsoft.Json.Linq.JValue)data["success"]).Value : ""));

                return data.Value<ulong>("orderNumber");
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool DeleteOrder(CurrencyPair currencyPair, ulong orderId)
        {
            var postData = new Dictionary<string, object> {
                { "currencyPair", currencyPair },
                { "orderNumber", orderId }
            };

            var data = PostData<JObject>("cancelOrder", postData);
            return data.Value<byte>("success") == 1;
        }

        public Task<IList<IOrder>> GetOpenOrdersAsync(CurrencyPair currencyPair)
        {
            return Task.Factory.StartNew(() => GetOpenOrders(currencyPair));
        }

        public Task<IList<ITrade>> GetTradesAsync(CurrencyPair currencyPair, DateTime startTime, DateTime endTime)
        {
            return Task.Factory.StartNew(() => GetTrades(currencyPair, startTime, endTime));
        }

        public Task<IList<ITrade>> GetTradesAsync(CurrencyPair currencyPair)
        {
            return Task.Factory.StartNew(() => GetTrades(currencyPair, Helper.DateTimeUnixEpochStart, DateTime.MaxValue));
        }

        public Task<ulong> PostOrderAsync(CurrencyPair currencyPair, OrderType type, double pricePerCoin, double amountQuote)
        {
            return Task.Factory.StartNew(() => PostOrder(currencyPair, type, pricePerCoin, amountQuote));
        }

        public Task<bool> DeleteOrderAsync(CurrencyPair currencyPair, ulong orderId)
        {
            return Task.Factory.StartNew(() => DeleteOrder(currencyPair, orderId));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private T PostData<T>(string command, Dictionary<string, object> postData)
        {
            return ApiWebClient.PostData<T>(command, postData);
        }

        public IList<ITrade> GetTrades(CurrencyPair currencyPair)
        {
            return GetTrades(currencyPair, Helper.DateTimeUnixEpochStart, DateTime.MaxValue);
        }
    }
}
