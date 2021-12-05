using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Extensions.Extensions
{
    public static class Extension
    {
        public static string ConvertToBTC(this double amount)
        {
            return "You have "+(amount / 49.165).ToString()+"BTC";
        }

        public static string ConvertToETH(this double amount)
        {
            return "You have "+(amount / 4.128).ToString()+"ETH";
        }
    }
}
