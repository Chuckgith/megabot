using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jojatekok.PoloniexAPI
{
    public class BalanceModel
    {

        public string Type { get; set; }

        public double QuoteAvailable { get; set; }

        public double QuoteOnOrders { get; set; }

        public double USDT_Value { get; set; }

    }
}
