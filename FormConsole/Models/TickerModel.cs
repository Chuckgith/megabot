using Jojatekok.PoloniexAPI;
using Jojatekok.PoloniexAPI.MarketTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FormConsole
{
    public class TickerModel
    {
        public CurrencyPair CurrencyPair { get; set; }
        public EnumStatus Status { get; set; }

        public double PriceLast { get; set; }
        public double HighestPrice { get; set; }
        public double Profit { get; set; }
        public double HiguestProfit { get; set; }
        public double HighestProfitDiff { get; set; }      
        public double BaseCurrencyTotal { get; set; }
        public double UsdTotalValue { get; set; }
        public double LossTolerance { get; set; }
        public DateTime Time { get; set; }
    }
}