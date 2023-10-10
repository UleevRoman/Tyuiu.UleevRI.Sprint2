using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint2.Task4.V9.Lib;

namespace Tyuiu.UleevRI.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 14;
            double res = ds.Calculate(x, y);
            double wait = 4398046511104;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 15.25;
            Assert.AreEqual(wait, res);
        }
    }
}
