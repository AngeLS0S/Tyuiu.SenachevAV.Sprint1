using Tyuiu.SenachevAV.Sprint1.Task6.V4.Lib;

namespace Tyuiu.SenachevAV.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Деревянный оловянный ветреный";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(strTest);
            string wait = "Деревянный оловянный";
            Assert.AreEqual(wait, res);
        }
    }
}