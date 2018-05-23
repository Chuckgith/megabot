using Jojatekok.PoloniexAPI;
using Jojatekok.PoloniexAPI.MarketTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jojatekok.PoloniexAPI
{
    public class MarketController
    {
        PoloniexClient _poloniexClient;
        private PoloniexClient PoloniexClient
        {
            get
            {
                if (_poloniexClient == null)
                {
                    _poloniexClient = new PoloniexClient(ApiKeys.PublicKey, ApiKeys.PrivateKey);
                }
                return _poloniexClient;
            }
        }

        public List<MarketDataModel> GetMarketSummary()
        {         
            var markets = PoloniexClient.Markets.GetSummarySync();

            var ListMarket = new List<MarketDataModel>();

            foreach (var item in markets)
            {
                ListMarket.Add(new MarketDataModel()
                {
                    Market = item.Key.ToString(),
                    OrderSpreadPercentage = item.Value.OrderSpreadPercentage,
                    OrderTopBuy = item.Value.OrderTopBuy,
                    OrderTopSell = item.Value.OrderTopSell,
                    PriceLast = item.Value.PriceLast,
                    OrderSpread = item.Value.OrderSpread,
                    PriceChangePercentage = item.Value.PriceChangePercentage,
                    Volume24HourBase = item.Value.Volume24HourBase,
                    Volume24HourQuote = item.Value.Volume24HourQuote
                });
            }

            return ListMarket;
        }

        // #######################################################################################################
        // ##########################################     Chuck    ##############################################
        // #######################################################################################################

        /// <summary>
        /// Gets a data summary of the markets available.
        /// </summary>
        /// <returns></returns>
        public IDictionary<CurrencyPair, IMarketData> GetSummary()
        {
            return PoloniexClient.Markets.GetSummarySync();
        }

        public IList<CurrencyPair> GetMarket(string currencyBase)
        {
            IList<CurrencyPair> market =
                (from m in GetSummary()
                 where m.Key.BaseCurrency == currencyBase
                 orderby m.Key.QuoteCurrency
                 select m.Key).ToList();

            return market;
        }

        /// <summary>
        /// Gets a data summary of a specific market.
        /// </summary>
        /// <param name="currencyPair"></param>
        /// <returns></returns>
        public IMarketData GetMarket(CurrencyPair currencyPair)
        {
            IMarketData market =
                (from m in GetSummary()
                 where m.Key.BaseCurrency == currencyPair.BaseCurrency
                 && m.Key.QuoteCurrency == currencyPair.QuoteCurrency
                 select m.Value).Single();

            return market;
        }

        /// <summary>
        /// Gets a data summary of a specific market.
        /// </summary>
        /// <param name="markets"></param>
        /// <param name="currencyPair"></param>
        /// <returns></returns>
        public IMarketData GetMarket(IDictionary<CurrencyPair, IMarketData> markets, CurrencyPair currencyPair)
        {
            IMarketData market =
                (from m in markets
                 where m.Key.BaseCurrency == currencyPair.BaseCurrency
                 && m.Key.QuoteCurrency == currencyPair.QuoteCurrency
                 select m.Value).Single();

            return market;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currencyPair"></param>
        /// <param name="depth"></param>
        /// <returns></returns>
        public IOrderBook GetOpenOrders(CurrencyPair currencyPair, uint depth)
        {
            return PoloniexClient.Markets.GetOpenOrdersSync(currencyPair, depth);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currencyPair"></param>
        /// <returns></returns>
        public IList<IMarketChartData> GetChartDataSync(CurrencyPair currencyPair, DateTime startTime)
        {
            MarketController marketController = new MarketController();
            IList<IMarketChartData> test = PoloniexClient.Markets.GetChartDataSync(currencyPair, MarketPeriod.Minutes5, startTime, DateTime.UtcNow);

            return test;
        }

        public IList<ITrade> MCGetTrades(CurrencyPair currencyPair, DateTime startTime, DateTime endTime)
        {
            return PoloniexClient.Markets.GetTrades(currencyPair, startTime, endTime);
        }
    }
}
