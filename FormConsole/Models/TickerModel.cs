﻿using Jojatekok.PoloniexAPI;
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
        public double PriceLast { get; set; }
        public double HighestPrice { get; set; }
        public double Profit { get; set; }
        public double HighestProfit { get; set; }
        public double HPDiff { get; set; }      
        public double BaseCurrencyTotal { get; set; }
        public double UsdtValue { get; set; }
        public DateTime LastTicker { get; set; }
    }
}