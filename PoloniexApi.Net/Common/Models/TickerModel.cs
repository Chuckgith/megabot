using Jojatekok.PoloniexAPI.MarketTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Jojatekok.PoloniexAPI
{
    public class TickerModel
    {
        public CurrencyPair currencyPair { get; set; }
        public double amountToTrade { get; set; }
        public double pricePaid { get; set; }
        public double priceLast { get; set; }
        public double highestPrice { get; set; }
        public double profit { get; set; }
        public double higuestProfit { get; set; }
        public double highestProfitDiff { get; set; }
        public double lossTolerance { get; set; }        
        public double baseCurrencyTotal { get; set; }
        public double usdTotalValue { get; set; }
        public DateTime time { get; set; }
    }
}