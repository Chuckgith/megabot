using Jojatekok.PoloniexAPI;
using MailKit;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FormConsole
{
    static class Signal
    {
        public static EnumStates ExecuteBuySell(MimeMessage message, EnumStates lastState)
        {
            CurrencyPair currencyPair = null;
            OrderModel order = new OrderModel();

            // Enlève ceci: "TradingView Alert: "
            var valueSplit = message.Subject.Remove(0, 19).Split(',');
            currencyPair = new CurrencyPair(valueSplit[0].Trim().ToUpper());

            if (lastState == EnumStates.WAITING && message.Subject.Contains("sell"))
                return lastState;
            else if (lastState == EnumStates.WAITING && message.Subject.Contains("buy"))
                lastState = EnumStates.SOLD;

            if (lastState == EnumStates.SOLD && message.Subject.Contains("buy"))
            {
                Console.WriteLine($"{DateTime.Now} - {message.Date.LocalDateTime} - {message.Subject.Remove(0, 19)}");
                lastState = EnumStates.BOUGHT;
                Buy(currencyPair);
            }
            else if (lastState == EnumStates.BOUGHT && message.Subject.Contains("sell"))
            {
                Console.WriteLine($"{DateTime.Now} - {message.Date.LocalDateTime} - {message.Subject.Remove(0, 19)}");
                lastState = EnumStates.SOLD;
                Sell(currencyPair);
            }

            return lastState;
        }

        private static OrderModel Buy(CurrencyPair currencyPair)
        {
            OrderModel order = new OrderModel();

            Console.WriteLine($"{DateTime.Now} - ACHETER!!");
            //order = BIZ.PostBestBuyOrder(currencyPair);
            Console.WriteLine($"{DateTime.Now} - OK DONE!! (idOrder: {order.IdOrder})\n");

            //try
            //{
            //    Process.Start($"D:\\code\\Polov3\\CoinBot_Cv2\\bin\\Debug\\CoinBot_Cv2.exe", $" {currencyPair.BaseCurrency} {currencyPair.QuoteCurrency} {0} {0} {idOrder}");
            //}
            //catch (Exception)
            //{
            //    Process.Start($"C:\\bot\\CoinBot\\Application Files\\CoinBot_Cv2_1_0_0_0\\CoinBot_Cv2.exe", $" {currencyPair.BaseCurrency} {currencyPair.QuoteCurrency} {0} {0} {idOrder}");
            //}

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