using Jojatekok.PoloniexAPI;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace FormConsole
{
    static class ExecuteOrder
    {
        static Business BIZ = new Business();

        public static OrderModel ExecuteBuySell(OrderType orderType, CurrencyPair currencyPair, double amount, bool realTrade)
        {
            OrderModel order = new OrderModel();

            if (orderType == OrderType.Buy)
            {
                order = Buy(currencyPair, amount, realTrade);
            }
            else if (orderType == OrderType.Sell)
            {
                order = Sell(currencyPair, amount, realTrade);
            }

            return order;
        }

        private static OrderModel Buy(CurrencyPair currencyPair, double amount, bool realTrade)
        {
            OrderModel order = new OrderModel();

            order = BIZ.PostBestBuyOrder(currencyPair, realTrade, amount);

            return order;
        }

        private static OrderModel Sell(CurrencyPair currencyPair, double amount, bool realTrade)
        {
            OrderModel order = new OrderModel();

            order = BIZ.PostBestSellOrder(currencyPair, realTrade, amount);

            return order;
        }
    }
}