﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SenachevAV.Sprint1.Task4.V18.Lib
{
    public class DataService : ISprint1Task4V18
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round ((Math.Sqrt(3 + x)) / (Math.Pow(x,2) + Math.Pow(y,2)), 3);
            return res;
        }
    }
}
