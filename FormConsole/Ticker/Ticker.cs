using Jojatekok.PoloniexAPI;
using Jojatekok.PoloniexAPI.MarketTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FormConsole
{
    class Ticker
    {
        public static string Display(
            CurrencyPair currencyPair, IMarketData market, double profit, double higuestProfit, double highestProfitDiff, double lossTolerance, double highestPrice,
            double baseCurrencyTotal, double usdTotalValue, double pricePaid, double amountToTrade)
        {
            return string.Format(
                "Last: {0}  |  {1}  |  USD_value: {2}  |  Profit: {3}  |  High_diff: {4} ({5})  |  Loss tolerance: {6}\n",
                    string.Format("{0,13:0.00000000}", market.PriceLast),
                    currencyPair.BaseCurrency + "_value: " + string.Format("{0,13:0.00000000}", baseCurrencyTotal),
                    string.Format("{0,8:0.00$}", usdTotalValue),
                    string.Format("{0,8:0.0000}%", profit),
                    (highestPrice < pricePaid) ? "---------" : (highestProfitDiff != 0 ? string.Format("{0,8:0.0000}%", highestProfitDiff) : "NEW_HIGH!"),
                    (highestPrice < pricePaid) ? "-------------" : string.Format("{0:0.00000000}", highestPrice),
                    string.Format("{0,2:0.00}", lossTolerance));
        }
    }
}