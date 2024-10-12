using Tyuiu.SenachevAV.Sprint1.Task7.V24.Lib;

namespace Tyuiu.SenachevAV.Sprint1.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 7;
            double wait = 0.509;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}