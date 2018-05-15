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
        public static OrderModel ExecuteBuySell(OrderType orderType, CurrencyPair currencyPair)
        {
            OrderModel order = new OrderModel();

            if (orderType == OrderType.Buy)
            {
                order = Buy(currencyPair);
                Thread.Sleep(2000);
            }
            else if (orderType == OrderType.Sell)
            {
                order = Sell(currencyPair);
                Thread.Sleep(2000);
            }

            return order;
        }

        private static OrderModel Buy(CurrencyPair currencyPair)
        {
            OrderModel order = new OrderModel();

            //order = BIZ.PostBestBuyOrder(currencyPair);

            return order;
        }

        private static OrderModel Sell(CurrencyPair currencyPair)
        {
            OrderModel order = new OrderModel();

            //order = BIZ.PostBestSellOrder(currencyPair, idOrder);

            return order;
        }
    }
}