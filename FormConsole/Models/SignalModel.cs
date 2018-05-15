using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FormConsole
{
    public class SignalModel
    {
        public CurrencyPair CurrencyPair { get; set; }
        public OrderType OrderType { get; set; }
    }
}