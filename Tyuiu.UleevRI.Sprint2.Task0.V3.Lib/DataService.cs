﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.UleevRI.Sprint2.Task0.V3.Lib
{
    public class DataService : ISprint2Task0V3
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y;
            res[1] = x != y;
            res[2] = x + 100 < y;
            res[3] = x + 100 > y;
            res[4] = x + 83 <= y;
            res[5] = x + 82 >= y;
            return res;
        }
    }
}
