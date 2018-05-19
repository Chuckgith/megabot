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

        public static OrderModel ExecuteBuySell(OrderType orderType, CurrencyPair currencyPair, double amount)
        {
            OrderModel order = new OrderModel();

            if (orderType == OrderType.Buy)
            {
                order = Buy(currencyPair, amount);
            }
            else if (orderType == OrderType.Sell)
            {
                order = Sell(currencyPair, amount);
            }

            return order;
        }

        private static OrderModel Buy(CurrencyPair currencyPair, double amount)
        {
            OrderModel order = new OrderModel();

            order = BIZ.PostBestBuyOrder(currencyPair, false, amount);

            return order;
        }

        private static OrderModel Sell(CurrencyPair currencyPair, double amount)
        {
            OrderModel order = new OrderModel();

            order = BIZ.PostBestSellOrder(currencyPair, false, amount);

            return order;
        }
    }
}