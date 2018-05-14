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
        public static OrderModel ExecuteBuySell(EnumStatus status, CurrencyPair currencyPair)
        {
            OrderModel order = new OrderModel();

            if (status == EnumStatus.WAITING)
                return null;

            if (status == EnumStatus.SOLD)
            {
                Console.WriteLine($"{DateTime.Now} - {currencyPair}");
                status = EnumStatus.BOUGHT;
                Buy(currencyPair);
            }
            else if (status == EnumStatus.BOUGHT)
            {
                Console.WriteLine($"{DateTime.Now} - {currencyPair}");
                status = EnumStatus.SOLD;
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