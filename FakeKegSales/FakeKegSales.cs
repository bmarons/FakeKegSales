using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

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
            Console.WriteLine("Enter a Start Date");
            var startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter An End Date");
            var endDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter a filename");
            var fileName = Console.ReadLine();
            Console.WriteLine("Enter number of sales");
            var numSales = Int32.Parse(Console.ReadLine());

            StreamWriter w = File.AppendText(fileName);

            for (int i = 0; i < numSales; i++)
            {
                KegSale test = new KegSale();
                test.SaleTime = HelperFunctions.RandDateTime(startDate,endDate);
                test.KegType = HelperFunctions.GetBeer();
                test.Distributor = HelperFunctions.GetDistributor(test.KegType);
                HelperFunctions.WriteToFile(test.ToString(), w);
                
            }

            w.Close();

        }


    }

       

}
