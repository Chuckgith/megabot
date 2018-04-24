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

        public static double Truncate(double number)
        {
            return Math.Truncate(number * ROUND_FOR_POLONIEX) / ROUND_FOR_POLONIEX;
        }
    }
}