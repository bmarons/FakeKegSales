﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
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



        public static Dictionary<string, string> BeerToDDistributor = new Dictionary<string, string>()
        {
            { "1/2 Blue Moon","Miller of the Rockies"},
            { "1/6 Blue Moon","Miller of the Rockies"},
            { "1/2 Bud Light","Eagle Dist Co"},
            { "1/4 Bud Light","Eagle Dist Co"},
            {"1/2 Budweiser","Eagle Dist Co"},
            {"1/6 Budweiser","Eagle Dist Co"},
            {"1/2 Coors Light","Miller of the Rockies"},
            {"1/4 Coors Light","Miller of the Rockies"},
            {"1/2 Dos Equis Amber","Miller of the Rockies"},
            {"1/2 Dos Equis Lager","Miller of the Rockies"},
            {"1/6 Dos Equis Lager","Miller of the Rockies"},
            {"1/2 Michelob Ultra","Eagle Dist Co"},
            {"1/6 Michelob Ultra","Eagle Dist Co"},
            {"1/2 Miller Lite","Miller of the Rockies"},
            {"1/4 Miller Lite","Miller of the Rockies"},
            {"1/2 Natural Light","Eagle Dist Co"},
            {"PBR 1/2 Barrel Keg","Miller of the Rockies"},
            {"1/2 Yuengling Lager","PA Proud"},
            {"1/4 Yuengling Lager","PA Proud"},

        };

        public static string GetDistributor(string beerName)
        {

            

            var distributor = BeerToDDistributor[beerName];
            return distributor;
        }

        private static List<string> _beersList = new List<string>()
        {
            "1/2 Miller Lite",
            "1/4 Miller Lite",
            "1/2 Blue Moon",
            "1/6 Blue Moon",
            "1/2 Bud Light",
            "1/4 Bud Light",
            "1/2 Budweiser",
            "1/6 Budweiser",
            "1/2 Coors Light",
            "1/4 Coors Light",
            "1/2 Dos Equis Amber",
            "1/2 Dos Equis Lager",
            "1/6 Dos Equis Lager",
            "1/2 Michelob Ultra",
            "1/6 Michelob Ultra",
            "1/2 Natural Light",
            "PBR 1/2 Barrel Keg",
            "1/2 Yuengling Lager",
            "1/4 Yuengling Lager",
            
        };

        public static string GetBeer()
        {
            var r = Rnd.Next(_beersList.Count);
            return _beersList[r];
        }

        
    
        public static void WriteToFile(string sale,StreamWriter fileName)
        {
            fileName.WriteLine(sale);
        }

    }

}