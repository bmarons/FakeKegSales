using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

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




        public static List<KeyValuePair<string, string>> beerToDDistributor = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("1/2 Miller Lite","Miller of the Rockies")
        };
        public static string GetDistributor(string beerName)
        {

            var distributor = beerToDDistributor.First(kvp => kvp.Key == beerName).Value;
            return distributor;
        }

    }

}