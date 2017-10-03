using System;
using System.Dynamic;

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
        static void Main(string[] args)
        {
            Console.WriteLine("I am the main program");
        }

    }

}
