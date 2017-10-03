using System;
using FakeKegSales;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFakeKegSales
{
    [TestClass]
    public class TestFakeKegSales
    {
        [TestMethod]
        public void TestToString()
        {
            var testKeg = new KegSale();
            testKeg.SaleTime = new DateTime(2017, 1, 18,12,12,12);
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
            var testDateTime = HelperFunctions.RandDateTime(startDate,endDate);
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



    }
}
