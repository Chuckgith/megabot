using Jojatekok.PoloniexAPI.TradingTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jojatekok.PoloniexAPI
{
    public class TradingController
    {
        PoloniexClient client = new PoloniexClient(ApiKeys.PublicKey, ApiKeys.PrivateKey);

        public List<OrderModel> GetAllOpenOrders()
        {

            var orders = client.Trading.GetAllOpenOrders();

            var listOrder = new List<OrderModel>();

            Type type = typeof(AllOrders);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo pi in properties)
            {
                try
                {
                    var orderList = (List<Order>)pi.GetValue(orders, null);

                    if (orderList != null && orderList.Count > 0)
                    {
                        foreach (var item in orderList)
                        {
                            listOrder.Add(new OrderModel()
                            {
                                CurrencyPair = CurrencyPair.Parse(pi.Name),
                                AmountBase = item.AmountBase,
                                AmountQuote = item.AmountQuote,
                                IdOrder = item.IdOrder,
                                OrderType = item.Type,
                                PricePerCoin = item.PricePerCoin
                            });
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
            return listOrder;
        }

        public ulong PostOrder(CurrencyPair currencyPair, OrderType type, double pricePerCoin, double amountQuote)
        {
            return client.Trading.PostOrder(currencyPair, type, pricePerCoin, amountQuote);
        }

        public bool DeleteOrder(CurrencyPair currencyPair, ulong orderId)
        {
            try
            {
                return client.Trading.DeleteOrder(currencyPair, orderId);
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
                return client.Trading.MoveOrder(currencyPair, orderId, pricePerCoin, amountQuote);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<ITrade> GetTrades(CurrencyPair currencyPair, DateTime startTime, DateTime endTime)
        {
            return client.Trading.GetTrades(currencyPair, startTime, endTime);
        }

        public IList<ITrade> GetTrades(CurrencyPair currencyPair)
        {
            return client.Trading.GetTrades(currencyPair);
        }
    }
}
