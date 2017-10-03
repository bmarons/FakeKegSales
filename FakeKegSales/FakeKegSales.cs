using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace FakeKegSales
{ 

    public class KegSale
    {
        public string KegType { get; set; }
        public string Distributor { get; set; }
        public DateTime SaleTime { get; set; }

        public override string ToString()
        {
            return KegType + "," + Distributor + "," + SaleTime;
        }
        
    }





    class FakeKegSales
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("I am the main program");

            List<string> beersList = new List<string>()
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


            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            for (int i = 0; i < 1000; i++)
            {
                int r = rnd.Next(beersList.Count);
                Console.WriteLine(HelperFunctions.GetDistributorDict(beersList[r]));

            }

            stopwatch2.Stop();


            Stopwatch stopwatch = new Stopwatch();



            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                int r = rnd.Next(beersList.Count);
                Console.WriteLine(HelperFunctions.GetDistributor(beersList[r]));
                
            }
            stopwatch.Stop();

            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            Console.WriteLine("Time elapsed: {0}", stopwatch2.Elapsed);




        }


    }

       

}
