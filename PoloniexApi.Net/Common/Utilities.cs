using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Jojatekok.PoloniexAPI
{
    public static class Utilities
    {
        const double ROUND_FOR_POLONIEX = 100000000;

        public static double? TryParseDouble(string text)
        {
            if (double.TryParse(text.Replace(".", ","), out double temp))
                return temp;
            return null;
        }

        public static double? TryParseDoublePolo(string text)
        {
            if (double.TryParse(text.Replace(".", ","), out double temp))
                return TruncateDouble(temp);
            return null;
        }

        public static double TruncateDouble(double number)
        {
            return Math.Truncate(number * ROUND_FOR_POLONIEX) / ROUND_FOR_POLONIEX;
        }

        public static double? TruncateDouble(double? number)
        {
            if (number == null)
                return null;

            return Math.Truncate(double.Parse(number.ToString()) * ROUND_FOR_POLONIEX) / ROUND_FOR_POLONIEX;
        }
    }
}