using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FormConsole
{
    public class FlatTradeModel
    {
        public CurrencyPair CurrencyPair { get; set; }
        public EnumStatus Status { get; set; }
        public string Amount { get; set; }
        public string LossTolerance { get; set; }
        public string LossToleranceMultiplicator { get; set; }
        public string PricePaid { get; set; }
        public string UsdTotalValue { get; set; }
        public string PriceLast { get; set; }
        public string Profit { get; set; }
        public string HighestProfit { get; set; }
        public string HighestProfitDiff { get; set; }
        public string ToleranceProfitHighDiff { get; set; }
        public string LastTicker { get; set; }
    }
}