using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint2.Task6.V13.Lib;

namespace Tyuiu.UleevRI.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(11.8, ds.FindDateOfNextDay(2012, 8, 10));
            Assert.AreEqual(1.3, ds.FindDateOfNextDay(2016, 2, 29));
            Assert.AreEqual(1.1, ds.FindDateOfNextDay(2020, 12, 31));
            Assert.AreEqual(21.5, ds.FindDateOfNextDay(2024, 5, 20));
            Assert.AreEqual(1.7, ds.FindDateOfNextDay(2028, 6, 30));
        }
    }
}
