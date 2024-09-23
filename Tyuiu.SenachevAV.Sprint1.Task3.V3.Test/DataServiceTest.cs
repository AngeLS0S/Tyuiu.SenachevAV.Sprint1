using Tyuiu.SenachevAV.Sprint1.Task3.V3.Lib;
namespace Tyuiu.SenachevAV.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 9;
            double b = 7.5;
            double h = 5;
            double wait = 337.5;
            var res = ds.ParallelepipedVolume(a, b, h);
            Assert.AreEqual(wait, res);
        }
    }
}