using System;
using FakeKegSales;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace TestFakeKegSales
{

    [TestClass]
    public class TestFakeKegSales
    {

        static Random rnd = new Random();

        [TestMethod]
        public void TestToString()
        {
            var testKeg = new KegSale();
            testKeg.SaleTime = new DateTime(2017, 1, 18, 12, 12, 12);
            testKeg.Distributor = "Miller of the Rockies";
            testKeg.KegType = "1/2 Miller Lite";
            Assert.AreEqual(testKeg.ToString(), "1/2 Miller Lite,Miller of the Rockies,1/18/2017 12:12:12 PM");
        }

        [TestMethod]
        public void TestToStringEmpty()
        {
            var testKeg = new KegSale();
            Assert.AreEqual(testKeg.ToString(), ",,1/1/0001 12:00:00 AM");
        }

        [TestMethod]
        public void TestToStringNoDistributor()
        {
            var testKeg = new KegSale();
            testKeg.SaleTime = new DateTime(2017, 1, 18, 12, 12, 12);
            testKeg.KegType = "1/2 Miller Lite";
            Assert.AreEqual(testKeg.ToString(), "1/2 Miller Lite,,1/18/2017 12:12:12 PM");
        }

        [TestMethod]
        public void TestrandDateTime()
        {
            var startDate = new DateTime(2015, 1, 18, 12, 12, 12);
            var endDate = new DateTime(2017, 1, 18, 12, 12, 56);
            var testDateTime = HelperFunctions.RandDateTime(startDate, endDate);
            Assert.IsTrue(testDateTime.Ticks > startDate.Ticks && testDateTime.Ticks < endDate.Ticks);
        }

        [TestMethod]
        public void TestRandDateTimeSameTime()
        {
            var startDate = new DateTime(2015, 1, 18, 12, 12, 12);
            var endDate = new DateTime(2015, 1, 18, 12, 12, 12);
            var testDateTime = HelperFunctions.RandDateTime(startDate, endDate);
            Assert.IsTrue(testDateTime.Ticks == testDateTime.Ticks);
        }

        [TestMethod]
        public void TestGetDistributor()
        {
            var test = HelperFunctions.GetDistributor("1/2 Miller Lite");
            Assert.AreEqual(test, "Miller of the Rockies");
        }



        [TestMethod]
        public void TestGetBeer()
        {

            var beerlist = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                beerlist.Add(HelperFunctions.GetBeer());
                
            }

            var total = 0;
            for (int i = 0; i < beerlist.Count; i++)
            {
                if (beerlist[i] == "1/2 Miller Lite")
                    total++;
            }

            Assert.IsTrue(total < 50);
            Console.WriteLine(total);
        }

        [TestMethod]
        public void TestWriteToFile()
        {
            StreamWriter w = File.AppendText("testing.txt");
            KegSale test = new KegSale();
            test.SaleTime = DateTime.Parse("11/11/11");
            test.KegType = "1/2 Miller Lite";
            test.Distributor = "Miller of the Rockies";
            HelperFunctions.WriteToFile(test.ToString(), w);
            w.Close();
            StreamReader r = new StreamReader("testing.txt");
            var readLine = r.ReadLine();
            Console.WriteLine(Directory.GetCurrentDirectory());
            Assert.AreEqual(test.ToString(), readLine);
            r.Close();
            File.Delete("testing.txt");

        }
    }
}