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
        public static string Display(TickerModel t)
        {
            return string.Format(
                "Last: {0}  |  {1}  |  USD_value: {2}  |  Profit: {3}  |  High_diff: {4} ({5})  |  Loss tolerance: {6}\n",
                    string.Format("{0,13:0.00000000}", t.priceLast),
                    t.currencyPair.BaseCurrency + "_value: " + string.Format("{0,13:0.00000000}", t.baseCurrencyTotal),
                    string.Format("{0,8:0.00$}", t.usdTotalValue),
                    string.Format("{0,8:0.0000}%", t.profit),
                    (t.highestPrice < t.pricePaid) ? "---------" : (t.highestProfitDiff != 0 ? string.Format("{0,8:0.0000}%", t.highestProfitDiff) : "NEW_HIGH!"),
                    (t.highestPrice < t.pricePaid) ? "-------------" : string.Format("{0:0.00000000}", t.highestPrice),
                    string.Format("{0,2:0.00}", t.lossTolerance));
        }
    }
}