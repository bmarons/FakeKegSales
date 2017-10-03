using System;
using FakeKegSales;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFakeKegSales
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToString()
        {
            var testKeg = new KegSale();
            testKeg.SaleTime = new DateTime(2017, 1, 18,12,12,12);
            testKeg.Distributor = "Miller of the Rockies";
            testKeg.KegType = "1/2 Miller Lite";
            Console.WriteLine(testKeg.ToString());
            Assert.AreEqual(testKeg.ToString(), "1/2 Miller Lite,Miller of the Rockies,1/18/2017 12:12:12 PM");

            


        }
    }
}
