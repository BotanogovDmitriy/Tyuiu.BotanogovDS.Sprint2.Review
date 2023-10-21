using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BotanogovDS.Sprint2.Review.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y) 
        {
            if (Math.Sin(x) >= y & y >= 0 & y <= 0.5 & x <= Math.PI & x >= 0)
            {

                return true;

            }
            return false;
        }
    }
}