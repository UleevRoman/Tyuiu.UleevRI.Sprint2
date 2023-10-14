using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.UleevRI.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public double FindDateOfNextDay(int g, int m, int n)
        {
            int D;
            int M;
            int d = n + 1;
            switch (m)
            {
                case 1:
                    if ((d >= 1) && (d <= 31))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 2:
                    if ((d >= 1) && (d <= 29))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 3:
                    if ((d >= 1) && (d <= 31))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 4:
                    if ((d >= 1) && (d <= 30))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 5:
                    if ((d >= 1) && (d <= 31))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 6:
                    if ((d >= 1) && (d <= 30))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 7:
                    if ((d >= 1) && (d <= 31))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 8:
                    if ((d >= 1) && (d <= 31))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 9:
                    if ((d >= 1) && (d <= 30))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 10:
                    if ((d >= 1) && (d <= 31))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 11:
                    if ((d >= 1) && (d <= 30))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = m + 1;
                    }
                    break;
                case 12:
                    if ((d >= 1) && (d <= 31))
                    {
                        D = d; M = m;
                    }
                    else
                    {
                        D = 1; M = 1;
                    }
                    break;
                default: throw new ArgumentException("Ошибка");
            }

            string ND = $"{D},{M}";
            double res = Convert.ToDouble(ND);
            return res;
        }
    }
}
