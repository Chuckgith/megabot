using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jojatekok.PoloniexAPI
{
    public class OrderModel 
    {
        public CurrencyPair CurrencyPair { get; set; }
        public ulong IdOrder { get;  set; }   
        public OrderType OrderType { get;  set; }     
        public double PricePerCoin { get;  set; }      
        public double AmountQuote { get;  set; }      
        public double AmountBase { get;  set; }
    }
}
