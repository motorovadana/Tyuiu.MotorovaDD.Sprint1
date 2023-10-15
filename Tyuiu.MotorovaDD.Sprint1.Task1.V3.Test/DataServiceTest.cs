using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MotorovaDD.Sprint1.Task1.V3.LIB;

namespace Tyuiu.MotorovaDD.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpreassion()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(2.8, res);
        }
    }
}
