﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint2.Task2.V8.Lib;

namespace Tyuiu.UleevRI.Sprint2.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 11; int y = 7;
            bool res = ds.CheckDotInShadedArea(x, y); bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
