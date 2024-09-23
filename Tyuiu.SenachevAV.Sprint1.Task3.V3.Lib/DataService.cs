using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SenachevAV.Sprint1.Task3.V3.Lib
{
    public class DataService : ISprint1Task3V3
    {
        public double ParallelepipedVolume(double a, double b, double h)
        {
            return Math.Round (a * b * h, 3);
        }
    }
}
