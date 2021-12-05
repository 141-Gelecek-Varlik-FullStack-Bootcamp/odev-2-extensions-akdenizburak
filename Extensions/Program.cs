using Extensions.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Extensions
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double USD = 8.256;

            Console.WriteLine(USD.ConvertToETH());
        }
    }
}
