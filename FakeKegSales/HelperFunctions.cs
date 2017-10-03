using System;
using System.Dynamic;

namespace FakeKegSales
{

    public class HelperFunctions

    {
        private static readonly Random Rnd = new Random();
        public static DateTime RandDateTime(DateTime start, DateTime end)
        {
                var range = end - start;
                var randTimeSpan = new TimeSpan((long)(Rnd.NextDouble() * range.Ticks));
                return start + randTimeSpan;
        }

        public static string GetDistributor(string beerName)
        {
            return "";
        }

    }

}