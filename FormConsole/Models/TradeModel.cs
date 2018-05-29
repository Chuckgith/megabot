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
        public double ToleranceBuy { get; set; }
        public double Tolerance { get; set; }
        public double Multiplicator { get; set; }
        public double Amount { get; set; }
        public double PricePaid { get; set; }
        public double TolAjusted { get; set; }
        public DateTime TimeBuy { get; set; }
        public string Action { get; set; }

        public TickerModel Ticker { get; set; }

        public TradeModel()
        {
        }

        public TradeModel(TradeModel trade)
        {
            CurrencyPair = trade.CurrencyPair;
            Status = trade.Status;
            ToleranceBuy = trade.ToleranceBuy;
            Tolerance = trade.Tolerance;
            Multiplicator = trade.Multiplicator;
            Amount = trade.Amount;
            PricePaid = trade.PricePaid;
            TolAjusted = trade.TolAjusted;
            TimeBuy = trade.TimeBuy;
            Action = trade.Action;

            if (trade.Ticker != null)
            { 
                Ticker = new TickerModel()
                {
                    BaseCurrencyTotal = trade.Ticker.BaseCurrencyTotal,
                    HighestPrice = trade.Ticker.HighestPrice,
                    HighestProfit = trade.Ticker.HighestProfit,
                    HPDiff = trade.Ticker.HPDiff,
                    LastTicker = trade.Ticker.LastTicker,
                    PriceLast = trade.Ticker.PriceLast,
                    Profit = trade.Ticker.Profit,
                    UsdtValue = trade.Ticker.UsdtValue
                };
            }
        }
    }
}