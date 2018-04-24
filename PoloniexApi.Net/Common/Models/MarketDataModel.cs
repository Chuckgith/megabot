using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jojatekok.PoloniexAPI
{
    public class MarketDataModel
    {

        public string Market { get; set; }
        public double PriceLast { get; set; }
        public double PriceChangePercentage { get; set; }
        public double Volume24HourBase { get; set; }
        public double Volume24HourQuote { get; set; }
        public double OrderTopBuy { get; set; }
        public double OrderTopSell { get; set; }
        public double OrderSpread { get; set; }
        public double OrderSpreadPercentage { get; set; }
        bool IsFrozen { get; }
    }
}
