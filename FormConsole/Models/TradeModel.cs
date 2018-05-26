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
        public BotModel Bot { get; set; }
        public TickerModel Ticker { get; set; }

        public TradeModel()
        {
            Bot = new BotModel();
            //Ticker = new TickerModel();
        }
    }
}