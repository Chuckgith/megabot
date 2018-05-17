using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FormConsole
{
    public class FlatBotModel
    {
        public CurrencyPair CurrencyPair { get; set; }
        public EnumStatus Status { get; set; }
        public double Amount { get; set; }
        public double LossTolerance { get; set; }
        public double LossToleranceMultiplicator { get; set; }
        public double ToleranceProfitHighDiff { get; set; }
        
        public double PricePaid { get; set; }

        public double PriceLast { get; set; }
        public double HighestPrice { get; set; }
        public double Profit { get; set; }
        public double HiguestProfit { get; set; }
        public double HighestProfitDiff { get; set; }
        public double BaseCurrencyTotal { get; set; }
        public double UsdTotalValue { get; set; }
        public DateTime LastTicker { get; set; }
    }
}