using Tyuiu.SenachevAV.Sprint1.Task2.V19.Lib;

namespace Tyuiu.SenachevAV.Sprint1.Task2.V19Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 79;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(2,01, res);
        }
    }
}