﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint2.Task0.V3.Lib;

namespace Tyuiu.UleevRI.Sprint2.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 45;
            int y = 127;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {false, true, false, true, false, true};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
