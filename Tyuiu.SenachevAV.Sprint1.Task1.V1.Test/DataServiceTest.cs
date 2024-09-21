using Tyuiu.SenachevAV.Sprint1.Task1.V1.Lib;

namespace Tyuiu.SenachevAV.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 1;
            double a = 2;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(15, res);
        }
    }
}