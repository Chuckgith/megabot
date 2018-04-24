using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jojatekok.PoloniexAPI
{
    public class TradeHistoryModel
    {
        public CurrencyPair CurrencyPair { get; set; }
        public int globalTradeID { get; set; }
        public string tradeID { get; set; }
        public string date { get; set; }
        public string rate { get; set; }
        public string amount { get; set; }
        public string total { get; set; }
        public string fee { get; set; }
        public string orderNumber { get; set; }
        public string type { get; set; }
        public string category { get; set; }
    }
}
