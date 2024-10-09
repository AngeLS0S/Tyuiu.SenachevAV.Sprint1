using Tyuiu.SenachevAV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.SenachevAV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 16;
            double x2 = 23;
            double y1 = 10;
            double y2 = 25;
            
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x2, x1, y2, y1);

            int result = Convert.ToInt32(res);

            int wait = 17; 
            Assert.AreEqual(wait, result);

        }
    }
}