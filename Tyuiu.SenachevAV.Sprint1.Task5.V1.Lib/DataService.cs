using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SenachevAV.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x2, double x1, double y2, double y1)
        {
            int res = Convert.ToInt32(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            return res;
        }
    }
}
