using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FormConsole
{
    public class FlatTradeModel
    {
        public CurrencyPair CurrencyPair { get; set; }
        public EnumStatus Status { get; set; }        
        public string LossTolerance { get; set; }
        public string LossToleranceMultiplicator { get; set; }
        public string Amount { get; set; }

        public string UsdtValue { get; set; }
        public string PricePaid { get; set; }        
        public string PriceLast { get; set; }
        public string Profit { get; set; }
        public string HighestProfit { get; set; }
        public string HighestProfitDiff { get; set; }
        public string ToleranceProfitHighDiff { get; set; }
        public string TimeBuy { get; set; }
        public string LastTicker { get; set; }
        public string Action { get; set; }

        public FlatTradeModel(TradeModel trade)
        {
            CurrencyPair = trade.CurrencyPair;
            Status = trade.Status;            
            LossTolerance = trade.Tolerance.ToString();
            LossToleranceMultiplicator = trade.Multiplicator.ToString();
            Amount = trade.Amount.ToString();            

            if (trade.Ticker != null)
            {
                UsdtValue = string.Format("{0:0.00}", trade.Ticker.UsdtValue);
                PricePaid = string.Format("{0:0.00000000}", trade.PricePaid);
                PriceLast = string.Format("{0:0.00000000}", trade.Ticker.PriceLast);
                Profit = string.Format("{0:0.0000}", trade.Ticker.Profit);
                HighestProfit = string.Format("{0:0.0000}", trade.Ticker.HighestProfit);
                HighestProfitDiff = string.Format("{0:0.0000}", trade.Ticker.HighestProfitDiff == 0 ? "NEW HIGH" : string.Format("{0:0.0000}", trade.Ticker.HighestProfitDiff));
                ToleranceProfitHighDiff = string.Format("{0:0.00}", trade.ToleranceProfitHighDiff);
                TimeBuy = $"{trade.TimeBuy:dd/MM HH:mm:ss}";
                LastTicker = $"{trade.Ticker.LastTicker:dd/MM HH:mm:ss}";
                Action = "SELL";
            }
            else
            {
                Action = "BUY";
            }
        }
    }
}