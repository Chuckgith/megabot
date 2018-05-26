using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FormConsole
{
    public class FlatTradeModel : TradeModel
    {
        public string CurrencyPair { get { return Bot.CurrencyPair.ToString(); } }
        public string Status { get { return Bot.Status.ToString(); } }
        public string Tolerance { get { return Bot.Tolerance.ToString(); } }
        public string Multiplicator { get { return Bot.Multiplicator.ToString(); } }
        public string Amount { get { return Bot.Amount.ToString(); } }

        public string UsdtValue { get {
            if (Ticker == null) return string.Empty;
            return string.Format("{0:0.00}", Ticker.UsdtValue); } }

        public string PricePaid { get {
            if (Ticker == null) return string.Empty;
            return string.Format("{0:0.00000000}", Bot.PricePaid); } }

        public string PriceLast { get {
            if (Ticker == null) return string.Empty;
            return string.Format("{0:0.00000000}", Ticker.PriceLast); } }

        public string Profit { get {
            if (Ticker == null) return string.Empty;
            return string.Format("{0:0.0000}", Ticker.Profit); } }

        public string HighestProfit { get {
            if (Ticker == null) return string.Empty;
            return string.Format("{0:0.0000}", Ticker.HighestProfit); } }

        public string HPDiff { get {
            if (Ticker == null) return string.Empty;
            return string.Format("{0:0.0000}", Ticker.HPDiff == 0 ? "NEW HIGH" : string.Format("{0:0.0000}", Ticker.HPDiff)); } }

        public string ToleranceProfitHighDiff { get {
            if (Ticker == null) return string.Empty;
            return string.Format("{0:0.00}", Bot.ToleranceProfitHighDiff); } }

        public string TimeBuy { get {
            if (Ticker == null) return string.Empty;
            return $"{Bot.TimeBuy:dd/MM HH:mm:ss}"; } }
        
        public string LastTicker { get {
            if (Ticker == null) return string.Empty;
            return $"{Ticker.LastTicker:dd/MM HH:mm:ss}"; } }

        public string Action { get { return Bot.Action.ToString(); } }
        public TradeModel Trade { get; set; }

        public FlatTradeModel(TradeModel trade)
        {
            Trade = trade;
            
            Bot.CurrencyPair = trade.Bot.CurrencyPair;
            Bot.Status = trade.Bot.Status;
            Bot.Tolerance = trade.Bot.Tolerance;
            Bot.Multiplicator = trade.Bot.Multiplicator;
            Bot.Amount = trade.Bot.Amount;
            Bot.Action = trade.Bot.Action;

            //if (trade.Ticker != null)
            //{
            //    Ticker.UsdtValue = trade.Ticker.UsdtValue;
            //    Bot.PricePaid = trade.Bot.PricePaid;
            //    Ticker.PriceLast = trade.Ticker.PriceLast;
            //    Ticker.Profit = trade.Ticker.Profit;
            //    Ticker.HighestProfit = trade.Ticker.HighestProfit;
            //    Ticker.HPDiff = trade.Ticker.HPDiff;
            //    Bot.ToleranceProfitHighDiff = trade.Bot.ToleranceProfitHighDiff;
            //    Bot.TimeBuy = trade.Bot.TimeBuy;
            //    Ticker.LastTicker = trade.Ticker.LastTicker;
            //}
        }
    }
}