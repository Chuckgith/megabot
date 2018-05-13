using Jojatekok.PoloniexAPI;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FormConsole
{
    static class ExecuteOrder
    {
        public static OrderModel ExecuteBuySell(EnumStates lastState, CurrencyPair currencyPair)
        {
            OrderModel order = new OrderModel();

            if (lastState == EnumStates.WAITING)
                return null;

            if (lastState == EnumStates.SOLD)
            {
                Console.WriteLine($"{DateTime.Now} - {currencyPair}");
                lastState = EnumStates.BOUGHT;
                Buy(currencyPair);
            }
            else if (lastState == EnumStates.BOUGHT)
            {
                Console.WriteLine($"{DateTime.Now} - {currencyPair}");
                lastState = EnumStates.SOLD;
                Sell(currencyPair);
            }

            return order;
        }

        private static OrderModel Buy(CurrencyPair currencyPair)
        {
            OrderModel order = new OrderModel();

            Console.WriteLine($"{DateTime.Now} - ACHETER!!");
            //order = BIZ.PostBestBuyOrder(currencyPair);
            Console.WriteLine($"{DateTime.Now} - OK DONE!! (idOrder: {order.IdOrder})\n");

            return order;
        }

        private static OrderModel Sell(CurrencyPair currencyPair)
        {
            OrderModel order = new OrderModel();

            Console.WriteLine($"{DateTime.Now} - VENDRE!!");
            //order = BIZ.PostBestSellOrder(currencyPair, idOrder);
            Console.WriteLine($"{DateTime.Now} - OK DONE!!\n");

            return order;
        }
    }
}