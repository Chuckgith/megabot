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
        public new string CurrencyPair { get { return Trade.CurrencyPair.ToString(); } }
        public new string Status { get { return Trade.Status.ToString(); } }
        public new string ToleranceBuy { get { return Trade.ToleranceBuy.ToString(); } }
        public new string Tolerance { get { return Trade.Tolerance.ToString(); } }
        public new string Multiplicator { get { return Trade.Multiplicator.ToString(); } }
        public new string Amount { get { return Trade.Amount.ToString(); } }

        public string UsdtValue { get {
            if (Trade.Ticker == null) return string.Empty;
            return string.Format("{0:0.00}", Trade.Ticker.UsdtValue); } }

        public new string PricePaid { get {
            if (Trade.Ticker == null) return string.Empty;
            return string.Format("{0:0.00000000}", Trade.PricePaid); } }

        public string PriceLast { get {
            if (Trade.Ticker == null) return string.Empty;
            return string.Format("{0:0.00000000}", Trade.Ticker.PriceLast); } }

        public string Profit { get {
            if (Trade.Ticker == null) return string.Empty;
            return string.Format("{0:0.0000}", Trade.Ticker.Profit); } }

        public string HighestProfit { get {
            if (Trade.Ticker == null) return string.Empty;
            return string.Format("{0:0.0000}", Trade.Ticker.HighestProfit); } }

        public string HPDiff { get {
            if (Trade.Ticker == null) return string.Empty;
            return string.Format("{0:0.0000}", Trade.Ticker.HPDiff == 0 ? "NEW HIGH" : string.Format("{0:0.0000}", Trade.Ticker.HPDiff)); } }

        public new string TolAjusted { get {
            if (Trade.Ticker == null) return string.Empty;
            return string.Format("{0:0.00}", Trade.TolAjusted); } }

        public new string TimeBuy { get {
            if (Trade.Ticker == null) return string.Empty;
            return $"{Trade.TimeBuy:dd/MM HH:mm:ss}"; } }
        
        public string LastTicker { get {
            if (Trade.Ticker == null) return string.Empty;
            return $"{Trade.Ticker.LastTicker:dd/MM HH:mm:ss}"; } }

        public new string Action { get { return Trade.Action.ToString(); } }
        public TradeModel Trade { get; set; }

        public FlatTradeModel(TradeModel trade)
        {
            Trade = new TradeModel(trade);
        }
    }
}