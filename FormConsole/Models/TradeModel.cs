using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FormConsole
{
    public class TradeModel
    {
        public CurrencyPair CurrencyPair { get; set; }
        public EnumStatus Status { get; set; }        
        public double LossTolerance { get; set; }
        public double LossToleranceMultiplicator { get; set; }
        public double Amount { get; set; }
        public double PricePaid { get; set; }
        public double ToleranceProfitHighDiff { get; set; }        
        public TickerModel Ticker { get; set; }
    }
}