using Jojatekok.PoloniexAPI;
using Jojatekok.PoloniexAPI.MarketTools;
using PushMessage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TradingTools = Jojatekok.PoloniexAPI.TradingTools;

namespace CoinBot_Cv2
{
    enum EnumLastState
    {
        BOUGHT,
        SOLD,
        WAITING
    };

    public class Program
    {
        static Business BIZ = new Business();

        static EnumLastState lastState = EnumLastState.WAITING;

        const string CURRENCY_USDT = "USDT";
        const double TOLERANCE_PROFIT_PRICEPAID = -0.5;  // ex: -0.5 = -0.5%
        const double TOLERANCE_PROFIT_HIGHDIFF = -1;   // -1 => 5%, -1.5 => 7.5%, -2 => 10%
        const double LOSS_TOLERANCE_MULTIPLICATOR = 0.2;

        static string TIME { get { return string.Format("{0:dd\\.hh\\:mm\\:ss}  |  ", DateTime.Now.Subtract(Process.GetCurrentProcess().StartTime)); } }
        static bool IsAlertProfitPricePaidSent { get; set; }
        static bool IsAlertProfitHighestDiffSent { get; set; }

        enum ReasonToSell
        {
            TOLERANCE_PROFIT_PRICEPAID,
            TOLERANCE_PROFIT_HIGHDIFF,
        };

        static Mode mode;
        enum Mode
        {
            REAL,
            SIMULATION
        };

        static CancellationTokenSource ts = new CancellationTokenSource();

        public static void Main(string[] args)
        {
            Console.SetWindowSize(180, 20);
            Console.ForegroundColor = ConsoleColor.White;
            
            CancellationToken ct = ts.Token;
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    Console.Title = TIME +
                        Console.Title.Substring(16);

                    if (ct.IsCancellationRequested)
                    {
                        break;
                    }
                }
            }, ct);

            if (args.Length > 0)
            {
                //Console.WriteLine(string.Format(" {0} {1} {2} {3} {4}", args[0], args[1], args[2], args[3], args[4]));
                StartTrade(args[0], args[1], double.Parse(args[2]), double.Parse(args[3]), Convert.ToUInt64(args[4]));
            }
            else
            {
                Console.Write("Base currency: ");
                string baseCurrency = Console.ReadLine();
                baseCurrency = !string.IsNullOrEmpty(baseCurrency) ? baseCurrency.ToUpper() : "USDT";

                Console.Write("Quote currency: ");
                string quoteCurrency = Console.ReadLine();
                quoteCurrency = !string.IsNullOrEmpty(quoteCurrency) ? quoteCurrency.ToUpper() : "BTC";

                Console.Write("USDT to trade: ");
                double amountToTrade;
                bool isDouble = double.TryParse(Console.ReadLine(), out amountToTrade);
                amountToTrade = isDouble ? amountToTrade : 100;

                Console.Write("Price paid: ");
                double pricePaid;
                isDouble = double.TryParse(Console.ReadLine(), out pricePaid);
                pricePaid = isDouble ? pricePaid : 0;

                StartTrade(baseCurrency, quoteCurrency, amountToTrade, pricePaid);
            }
        }

        private static void StartTrade(string baseCurrency, string quoteCurrency, double amountToTrade, double pricePaid, ulong idOrder = 0)
        {
            IDictionary<CurrencyPair, IMarketData> markets;
            IMarketData marketToTrade = null;
            IMarketData usdtMarket = null;

            lastState = EnumLastState.BOUGHT;

            double previousProfit = -1;
            double profit = 0;
            double highestProfit = 0;
            double highestProfitDiff = 0;
            double highestPrice = 0;
            double baseCurrencyTotal = 0;
            double usdtValue = 0;
            double lossTolerance = 0;

            IsAlertProfitPricePaidSent = false;
            IsAlertProfitHighestDiffSent = false;
            var currencyPair = new CurrencyPair(baseCurrency, quoteCurrency);
            var currencyPairUsdt = new CurrencyPair(CURRENCY_USDT, baseCurrency);

            double baseCurrencyUnitPrice = 0;

            // Aller chercher le marché une 1ère fois en dehors du while pour figer dans le temps les données de départ
            markets = BIZ.GetSummary();
            marketToTrade = BIZ.GetCurrency(markets, currencyPair);

            if (idOrder != 0)
            {
                mode = Mode.REAL;

                // Aller chercher les vraies chiffres
                amountToTrade = (from x in BIZ.GetBalances() where x.Type == currencyPair.QuoteCurrency select x.USDT_Value).SingleOrDefault();
               
                pricePaid = BIZ.GetTrades(currencyPair).Where(x => x.IdOrder == idOrder).FirstOrDefault().PricePerCoin;
            }
            else
            {
                mode = Mode.SIMULATION;

                // Si le prix payé n'a pas été défini par l'utilisateur, prendre le prix courant
                if (pricePaid == 0)
                    pricePaid = BIZ.FindBestPrice(currencyPair, OrderType.Buy);
            }

            // Enlève un pourcentage du montant à transiger si le prix payé était plus haut que le prix courant
            amountToTrade = amountToTrade + (marketToTrade.PriceLast / pricePaid) * 100 - 100;

            // Identifier l'unité de base de la monnaie à marchander
            if (baseCurrency == CURRENCY_USDT)
            {
                baseCurrencyUnitPrice = amountToTrade / marketToTrade.PriceLast;
            }
            else
            {
                usdtMarket = BIZ.GetCurrency(markets, currencyPairUsdt);
                baseCurrencyUnitPrice = (amountToTrade / usdtMarket.PriceLast) / marketToTrade.PriceLast;
            }
            
            try
            {
                while (lastState == EnumLastState.BOUGHT)
                {
                    marketToTrade = BIZ.GetCurrency(currencyPair);

                    profit = (marketToTrade.PriceLast / pricePaid) * 100 - 100;
                    highestProfit = profit > highestProfit ? profit : highestProfit;
                    lossTolerance = TOLERANCE_PROFIT_HIGHDIFF + (highestProfit * LOSS_TOLERANCE_MULTIPLICATOR);

                    // Évite d'afficher les données si rien n'a changé
                    if (Math.Round(previousProfit, 4) != Math.Round(profit, 4))
                    {
                        previousProfit = profit;
                        highestPrice = marketToTrade.PriceLast > highestPrice ? marketToTrade.PriceLast : highestPrice;
                        highestProfitDiff = (marketToTrade.PriceLast / highestPrice) * 100 - 100;
                        baseCurrencyTotal = marketToTrade.PriceLast * baseCurrencyUnitPrice;
                        usdtValue = baseCurrencyTotal * (baseCurrency == CURRENCY_USDT ? 1 : usdtMarket.PriceLast);
                        Display(currencyPair, marketToTrade, profit, highestProfit, highestProfitDiff, lossTolerance, highestPrice, baseCurrencyTotal, usdtValue, pricePaid, amountToTrade);
                        CheckTolerance(profit, highestProfit, highestProfitDiff, lossTolerance, marketToTrade, pricePaid, currencyPair, idOrder);
                    }

                    Thread.Sleep(5000);
                }

                ts.Cancel();

                Console.WriteLine(string.Format("Console paused... press any key to continue"));
                Console.ReadKey(); // press any key to continue
            }
            catch (Exception ex)
            {
                Console.Write($"{ex}\n");
            }            

            Console.WriteLine(string.Format("C'EST VENDU!!!"));
            Console.WriteLine(string.Format("Console paused... press any key to continue"));
            Console.ReadKey(); // press any key to continue            
        }

        private static void CheckTolerance(double profit,double highestProfit, double highestProfitDiff, 
            double lossTolerance, IMarketData marketToTrade, double pricePaid, CurrencyPair currencyPair, ulong idOrder)
        {
            double volume = marketToTrade.Volume24HourQuote;

            if (profit < TOLERANCE_PROFIT_PRICEPAID)
            {
                System.Media.SystemSounds.Exclamation.Play();

                Console.Title += string.Format(
                    "  |  {0} (limit: {1}% - High_diff: {2}%)",
                        ReasonToSell.TOLERANCE_PROFIT_PRICEPAID,
                        TOLERANCE_PROFIT_PRICEPAID,
                        string.Format("{0:0.0000}", highestProfitDiff));

                Console.WriteLine(string.Format("\n{0} ({1}%)\n", ReasonToSell.TOLERANCE_PROFIT_PRICEPAID, TOLERANCE_PROFIT_PRICEPAID));

                //if (mode == Mode.REAL)
                    //BIZ.PostBestSellOrder(currencyPair, idOrder);

                lastState = EnumLastState.SOLD;
            }

            if (highestProfitDiff < -0.3 &&
                highestProfitDiff < lossTolerance)
            {
                System.Media.SystemSounds.Exclamation.Play();

                Console.Title += string.Format(
                    "  |  {0} (limit: {1}% - High_diff: {2}%)",
                        ReasonToSell.TOLERANCE_PROFIT_HIGHDIFF,
                        lossTolerance,
                        string.Format("{0:0.0000}", highestProfitDiff));

                Console.WriteLine(string.Format("\n{0} ({1}%)\n", ReasonToSell.TOLERANCE_PROFIT_HIGHDIFF, TOLERANCE_PROFIT_HIGHDIFF));

                //if (mode == Mode.REAL)
                    //BIZ.PostBestSellOrder(currencyPair, idOrder);

                lastState = EnumLastState.SOLD;
            }
        }

        private static bool CheckQuoteOnOrders(CurrencyPair currencyPair)
        {
            if ((from x in BIZ.GetBalances() where x.Type == currencyPair.QuoteCurrency select x.USDT_Value).SingleOrDefault() >= 1) // 1$
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void Display(
            CurrencyPair currencyPair, IMarketData market, double profit, double highestProfit, double highestProfitDiff, double lossTolerance, double highestPrice, 
            double baseCurrencyTotal, double usdtValue, double pricePaid, double amountToTrade)
        {
            string arrow = SetDisplay(profit);

            Console.Title = string.Format(TIME +
                "{1}_{2}  |  Price paid: {3} (USD: {8}) |  Last: {4}  |  {0}Profit: {5}  |  High_diff: {6} ({7})",
                    arrow,
                    currencyPair.BaseCurrency,
                    currencyPair.QuoteCurrency,
                    string.Format("{0:0.00000000}", pricePaid),
                    string.Format("{0:0.00000000}", market.PriceLast),
                    string.Format("{0:0.0000}%", profit),
                    (highestProfitDiff != 0 ? string.Format("{0,8:0.0000}%", highestProfitDiff) : "NEW_HIGH!"), 
                    string.Format("{0:0.00000000}", highestPrice),
                    string.Format("{0:0.00$}", amountToTrade));

            Console.Write(string.Format(
                "Last: {0}  |  {1}  |  USD_value: {2}  |  Profit: {3}  |  High_diff: {4} ({5})  |  Loss tolerance: {6}\n",
                    string.Format("{0,13:0.00000000}", market.PriceLast),                    
                    currencyPair.BaseCurrency + "_value: " + string.Format("{0,13:0.00000000}", baseCurrencyTotal),
                    string.Format("{0,8:0.00$}", usdtValue),
                    string.Format("{0,8:0.0000}%", profit),
                    (highestPrice < pricePaid) ? "---------" : (highestProfitDiff != 0 ? string.Format("{0,8:0.0000}%", highestProfitDiff) : "NEW_HIGH!"),
                    (highestPrice < pricePaid) ? "-------------" : string.Format("{0:0.00000000}", highestPrice),
                    string.Format("{0,2:0.00}", lossTolerance)));
        }

        private static string SetDisplay(double profit)
        {
            string arrow = string.Empty;

            if (profit <= -2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                arrow = "▼▼▼ ";
            }
            if (profit <= -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                arrow = "▼▼ ";
            }
            else if (profit < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                arrow = "▼ ";
            }
            else if (profit < 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                arrow = "▲ ";
            }
            else if (profit >= 1 && profit < 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                arrow = "▲▲ ";
            }
            else if (profit >= 2 && profit < 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                arrow = "▲▲▲ ";
            }
            else if (profit >= 3 && profit < 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                arrow = "▲▲▲▲ ";
            }
            else if (profit >= 4)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                arrow = "▲▲▲▲▲ ";
            }

            return arrow;
        }
    }
}
