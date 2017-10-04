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


        }


    }

       

}
