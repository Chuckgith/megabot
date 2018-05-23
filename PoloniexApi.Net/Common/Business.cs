using Jojatekok.PoloniexAPI.MarketTools;
using PushMessage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;

namespace Jojatekok.PoloniexAPI
{
    public class Business
    {
        public PushMessageClient Push = new PushMessageClient();
        PoloniexClient Client = new PoloniexClient(ApiKeys.PublicKey, ApiKeys.PrivateKey);

        const int MIN_ORDER_AMOUNT = 50;
        const double BEST_PRICE_MULTIPLICATOR = 0.0000001;
        const int SLEEP_BETWEEN_MOVEORDER = 2000;

        public double? Prixpaye = null;
        public double PrixActuelCurrencyQuote = 0;
        public double PrixPlusFort = 0;
        public double pourcentageRisque = 0;
        public const decimal TolerancePerteProfits = -3m;
        public const decimal TolerancePerteProfitsMax = -3m;
        public double? QuoteAvailable = null;
        public double? prixActuelCurrencyBase = null;
        public List<string> ListeCoinOnOrder;

        MarketController _mc;
        private MarketController MC
        {
            get
            {
                if (_mc == null)
                {
                    _mc = new MarketController();
                }
                return _mc;
            }
        }

        WalletController _wc;
        private WalletController WC
        {
            get
            {
                if (_wc == null)
                {
                    _wc = new WalletController();
                }
                return _wc;
            }
        }

        static TradingController _tc;
        static TradingController TC
        {
            get
            {
                if (_tc == null)
                {
                    _tc = new TradingController();
                }
                return _tc;
            }
        }

        public IDictionary<CurrencyPair, IMarketData> GetSummary()
        {
            return MC.GetSummary();
        }

        public IList<CurrencyPair> GetMarket(string currencyBase)
        {
            return MC.GetMarket(currencyBase);
        }

        public IMarketData GetCurrency(CurrencyPair currencyPair)
        {
            return MC.GetMarket(currencyPair);
        }

        public IMarketData GetCurrency(IDictionary<CurrencyPair, IMarketData> markets, CurrencyPair currencyPair)
        {
            return MC.GetMarket(markets, currencyPair);
        }

        public List<BalanceModel> GetBalances()
        {
            return WC.GetBalances();
        }

        public IList<TradingTools.ITrade> GetTrades(CurrencyPair currencyPair)
        {
            return TC.GetTrades(currencyPair);
        }

        public IList<TradingTools.ITrade> GetTrades(CurrencyPair currencyPair, DateTime startTime, DateTime endTime)
        {
            return TC.GetTrades(currencyPair, startTime, endTime);
        }

        public IList<MarketTools.ITrade> MCGetTrades(CurrencyPair currencyPair, DateTime startTime, DateTime endTime)
        {
            return MC.MCGetTrades(currencyPair, startTime, endTime);
        }

        public IOrderBook GetOpenOrders(CurrencyPair currencyPair, uint depth)
        {
            return MC.GetOpenOrders(currencyPair, depth);
        }

        public OrderModel PostBestBuyOrder(CurrencyPair currencyPair, bool realTrade, double USDT = 0)
        {
            if (!realTrade)
                return PostBestBuyOrderFictif(currencyPair, USDT);

            var tradeId = new ulong();
            OrderModel order = new OrderModel();
            double bestPricePerCoin = 0;
            double bestPricePerCoinTemp = 0;
            double amountQuote = 0; // Quantité de la monnaie à acheter

            // Procéder à l'achat
            do
            {
                try
                {
                    bestPricePerCoin = FindBestPrice(currencyPair, OrderType.Buy);
                    amountQuote = InitPost(currencyPair, bestPricePerCoin, OrderType.Buy, USDT);

                    if (amountQuote == 0)
                    {
                        Debug.WriteLine(string.Format("\nY'A RIEN À ACHETER !!!"));
                        return null;
                    }

                    // ### DANGER ### DANGER ### DANGER ### DANGER ### DANGER ### DANGER ### DANGER ### DANGER ### DANGER ###
                    // ######################################################################################################
                    tradeId = PostOrder(currencyPair, bestPricePerCoin, amountQuote, OrderType.Buy);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            while (tradeId == 0);

            // Tant que tout n'est pas acheté
            while ((from x in GetBalances() where x.Type == currencyPair.BaseCurrency select x.QuoteOnOrders).SingleOrDefault() > 0)
            {
                try
                {
                    bestPricePerCoinTemp = FindBestPrice(currencyPair, OrderType.Buy, amountQuote);

                    if (bestPricePerCoin != bestPricePerCoinTemp)   // empêche de me détrôner moi-même
                    {
                        bestPricePerCoin = bestPricePerCoinTemp;
                        Debug.WriteLine($"\nnew bestPrice {bestPricePerCoin}");

                        amountQuote = Utilities.TruncateDouble((from x in GetBalances() where x.Type == currencyPair.BaseCurrency select x.QuoteOnOrders).SingleOrDefault() / bestPricePerCoin);

                        if (amountQuote > 0)
                            tradeId = MoveOrder(currencyPair, tradeId, bestPricePerCoin, amountQuote);

                        Debug.WriteLine(string.Format("MoveOrder: amountQuote = {0}", amountQuote));
                    }

                    Thread.Sleep(SLEEP_BETWEEN_MOVEORDER);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }

            System.Media.SystemSounds.Exclamation.Play();
            Debug.WriteLine("TOUT ACHETÉ!\n");

            PushMessage("BOUGHT!",
                $"Currency: {currencyPair}\\n" +
                $"USDT: {string.Format("{0:0.00}$", (from x in GetBalances() where x.Type == currencyPair.QuoteCurrency select x.USDT_Value).SingleOrDefault())}\\n" +
                $"At: {bestPricePerCoin}");

            order.CurrencyPair = currencyPair;
            order.OrderType = OrderType.Buy;
            order.AmountBase = 0;
            order.AmountQuote = amountQuote;
            order.PricePerCoin = bestPricePerCoin;
            order.IdOrder = ulong.Parse(tradeId.ToString());

            return order;
        }

        public OrderModel PostBestBuyOrderFictif(CurrencyPair currencyPair, double USDT = 0)
        {
            OrderModel order = new OrderModel();
            double bestPricePerCoin = 0;
            double amountQuote = 0;

            bestPricePerCoin = FindBestPrice(currencyPair, OrderType.Buy);
            amountQuote = USDT;

            System.Media.SystemSounds.Exclamation.Play();

            //PushMessage("BOUGHT!",
            //    $"Currency: {currencyPair}\\n" +
            //    $"USDT: {string.Format("{0:0.00}$", USDT)}\\n" +
            //    $"At: {bestPricePerCoin}");

            order.CurrencyPair = currencyPair;
            order.OrderType = OrderType.Buy;
            order.AmountBase = 0;
            order.AmountQuote = amountQuote;
            order.PricePerCoin = bestPricePerCoin;
            order.IdOrder = 0;

            return order;
        }

        public OrderModel PostBestSellOrder(CurrencyPair currencyPair, bool realTrade, double USDT = 0, ulong previousIdOrder = 0)
        {
            if (!realTrade)
                return PostBestSellOrderFictif(currencyPair, USDT);

            var tradeId = new ulong();
            OrderModel order = new OrderModel();
            double bestPricePerCoin = 0;
            double bestPricePerCoinTemp = 0;
            double amountQuote = 0; // Quantité de la monnaie que je possède

            double profitMade = 0;
            IList<TradingTools.ITrade> trades = null;

            // Procéder à la vente
            do
            {
                try
                {
                    bestPricePerCoin = FindBestPrice(currencyPair, OrderType.Sell);
                    amountQuote = InitPost(currencyPair, bestPricePerCoin, OrderType.Sell, USDT);

                    if (amountQuote == 0)
                    {
                        Debug.WriteLine(string.Format("\nY'A RIEN À VENDRE !!!"));
                        return null;
                    }

                    // ### DANGER ### DANGER ### DANGER ### DANGER ### DANGER ### DANGER ### DANGER ### DANGER ### DANGER ###
                    // ######################################################################################################
                    tradeId = PostOrder(currencyPair, bestPricePerCoin, amountQuote, OrderType.Sell);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            while (tradeId == 0);

            // Tant que tout n'est pas vendu
            while ((from x in GetBalances() where x.Type == currencyPair.QuoteCurrency select x.QuoteOnOrders).SingleOrDefault() > 0) 
            {
                try
                {
                    bestPricePerCoinTemp = FindBestPrice(currencyPair, OrderType.Sell, amountQuote);

                    if (bestPricePerCoin != bestPricePerCoinTemp)   // empêche de me détrôner moi-même
                    {
                        bestPricePerCoin = bestPricePerCoinTemp;
                        Debug.WriteLine($"\nnew bestPrice: {bestPricePerCoin}");

                        amountQuote = (from x in GetBalances() where x.Type == currencyPair.QuoteCurrency select x.QuoteOnOrders).SingleOrDefault();

                        if (amountQuote > 0)
                            // Si erreur retournée = "Total must be at least 1", le move se fait pas et ça loop......
                            tradeId = MoveOrder(currencyPair, tradeId, bestPricePerCoin, amountQuote);

                        Debug.WriteLine(string.Format("MoveOrder: amountQuote = {0}", amountQuote));
                    }

                    Thread.Sleep(SLEEP_BETWEEN_MOVEORDER);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }            

            System.Media.SystemSounds.Exclamation.Play();
            Debug.WriteLine("TOUT VENDU!\n");

            //if (previousIdOrder != 0)
            //{
            //    trades = GetTrades(currencyPair);
            //    profitMade = (trades.Where(x => x.IdOrder == tradeId).FirstOrDefault().PricePerCoin -
            //                  trades.Where(x => x.IdOrder == previousIdOrder).FirstOrDefault().PricePerCoin) / 
            //                  trades.Where(x => x.IdOrder == previousIdOrder).FirstOrDefault().PricePerCoin;
            //}
            trades = GetTrades(currencyPair);
            profitMade = (GetLastTrade(trades, OrderType.Sell) - GetLastTrade(trades, OrderType.Buy)) / GetLastTrade(trades, OrderType.Buy);

            PushMessage("SOLD!",
                $"Currency: {currencyPair}\\n" + 
                $"USDT: {string.Format("{0:0.00}$", (from x in GetBalances() where x.Type == currencyPair.BaseCurrency select x.QuoteAvailable).SingleOrDefault())}\\n" +
                $"At: {bestPricePerCoin}\\n" +
                $"Profit: {string.Format("{0:0.00}%", profitMade * 100)}");

            order.CurrencyPair = currencyPair;
            order.OrderType = OrderType.Buy;
            order.AmountBase = 0;
            order.AmountQuote = amountQuote;
            order.PricePerCoin = bestPricePerCoin;
            order.IdOrder = ulong.Parse(tradeId.ToString());

            return order;
        }

        public OrderModel PostBestSellOrderFictif(CurrencyPair currencyPair, double USDT = 0)
        {
            OrderModel order = new OrderModel();
            double bestPricePerCoin = 0;
            double amountQuote = 0;

            bestPricePerCoin = FindBestPrice(currencyPair, OrderType.Sell);
            amountQuote = USDT;

            //PushMessage("SOLD!",
            //    $"Currency: {currencyPair}\\n" +
            //    $"USDT: {string.Format("{0:0.00}$", USDT)}\\n" +
            //    $"At: {bestPricePerCoin}\\n" +
            //    $"Profit: {string.Format("{0:0.00}%", 0 * 100)}");

            order.CurrencyPair = currencyPair;
            order.OrderType = OrderType.Buy;
            order.AmountBase = 0;
            order.AmountQuote = amountQuote;
            order.PricePerCoin = bestPricePerCoin;
            order.IdOrder = 0;

            return order;
        }

        private double InitPost(CurrencyPair currencyPair, double bestPricePerCoin, OrderType orderType, double USDT = 0)
        {
            double amountQuote = 0; // Quantité de la monnaie que je possède            

            if (orderType == OrderType.Buy)
                amountQuote = AmountQuoteToBuy(currencyPair, bestPricePerCoin, USDT);
            else if (orderType == OrderType.Sell)
                amountQuote = AmountQuoteToSell(currencyPair, bestPricePerCoin, USDT);

            Debug.WriteLine($"{orderType.ToString()}: {currencyPair}\n" +
                $"bestPricePerCoin = {bestPricePerCoin}\n" +
                $"amountQuote = {amountQuote}\n" +
                $"USDT = {Utilities.TruncateDouble(amountQuote * bestPricePerCoin)}");

            return amountQuote;
        }

        private double AmountQuoteToBuy(CurrencyPair currencyPair, double bestPricePerCoin, double USDT)
        {
            double amountQuote = 0;

            BalanceModel balance = (from x in GetBalances() where x.Type == currencyPair.BaseCurrency select x).SingleOrDefault();

            if (balance == null || balance.QuoteAvailable < 1)
                return 0;

            // Quantité à acheter
            // Quantité que je possède
            if (USDT == 0 || USDT > balance.QuoteAvailable)
            {
                // La valeur a descendue entre temps... on parle ici du USDT... hummm...
                amountQuote = Utilities.TruncateDouble(balance.QuoteAvailable / bestPricePerCoin);
            }
            else
            {
                // Transiger le montant spécifié dans le textbox
                amountQuote = Utilities.TruncateDouble(USDT / bestPricePerCoin);
            }

            return amountQuote;
        }

        private double AmountQuoteToSell(CurrencyPair currencyPair, double bestPricePerCoin, double USDT)
        {
            double amountQuote = 0;

            // TODO BOOOOOOGUE dans le else? ou dans le if si ça prend le truncate et * 100000000, apparemment juste quand je vends à partir du form
            // le if... si le usdt a monté plutot?, ben ça vend pas toute...

            BalanceModel balance = (from x in GetBalances() where x.Type == currencyPair.QuoteCurrency select x).SingleOrDefault();

            if (balance == null || balance.USDT_Value < 1)
                return 0;

            // Quantité que je possède
            if (USDT == 0 || USDT > balance.USDT_Value)
            {
                // La valeur a descendue entre temps
                //amountQuote = Math.Round(((from x in wc.GetBalances() where x.Type == currencyPair.QuoteCurrency select x.QuoteAvailable).SingleOrDefault() / bestPricePerCoin) * ROUND_FOR_POLONIEX) / ROUND_FOR_POLONIEX;
                amountQuote = balance.QuoteAvailable;
            }
            else
            {
                // Transiger le montant spécifié dans le textbox
                amountQuote = Utilities.TruncateDouble(USDT / bestPricePerCoin);
            }

            return amountQuote;
        }

        public double FindBestPrice(CurrencyPair currencyPair, OrderType orderType, double? amountQuote = null)
        {
            IOrderBook orders = GetOpenOrders(currencyPair, 20);

            double pricePerCoin = (from order in orders.BuyOrders
                                   where order.AmountBase > MIN_ORDER_AMOUNT && order.AmountBase != amountQuote
                                   select order.PricePerCoin).FirstOrDefault();

            if (orderType == OrderType.Buy)
            {
                // Ne pas prendre les ordres de montants ridicules
                // Ajouter un % à la meilleure offre pour être au top
                return Utilities.TruncateDouble(pricePerCoin + (pricePerCoin * BEST_PRICE_MULTIPLICATOR));
            }
            else // OrderType.Sell
            {
                // Ne pas prendre les ordres de montants ridicules
                // Ajouter un % à la meilleure offre pour être au top
                return Utilities.TruncateDouble(pricePerCoin - (pricePerCoin * BEST_PRICE_MULTIPLICATOR));
            }
        }

        private ulong PostOrder(CurrencyPair currencyPair, double bestPricePerCoin, double amountQuote, OrderType orderType)
        {
            var tradeId = new ulong();

            try
            {
                // Soumettre l'ordre et récupérer le ID
                tradeId = Client.Trading.PostOrder(currencyPair, orderType, bestPricePerCoin, amountQuote);
                Thread.Sleep(2000);
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        Debug.WriteLine("HTTP Status Code: " + (int) response.StatusCode);
                    }                    
                }
                return 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return 0;
            }

            return tradeId;
        }

        private ulong MoveOrder(CurrencyPair currencyPair, ulong tradeId, double bestPricePerCoin, double amountQuote)
        {
            // TODO Si erreur retournée = "Total must be at least 1", le move se fait pas et ça loop......

            var tempTradeId = new ulong();

            try
            {
                // Modifier l'ordre
                tempTradeId = Client.Trading.MoveOrder(currencyPair, tradeId, bestPricePerCoin, amountQuote);
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        Debug.WriteLine("HTTP Status Code: " + (int) response.StatusCode);
                    }                    
                }
                return tradeId;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return tradeId;
            }

            return tempTradeId != 0 ? tempTradeId : tradeId;
        }

        private double GetLastTrade(IList<TradingTools.ITrade> trades, OrderType orderType)
        {
            return trades.Where(x => x.Type == orderType).FirstOrDefault().PricePerCoin;
        }

        private void PushMessage(string title, string message)
        {
            var pushMessage = new PushMessageClient();

            pushMessage.PushMessage(title, message);
        }
    }  
}
