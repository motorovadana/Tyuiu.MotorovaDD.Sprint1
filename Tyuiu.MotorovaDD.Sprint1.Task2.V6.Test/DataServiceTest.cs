using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MotorovaDD.Sprint1.Task5.V2.Lib;

namespace Tyuiu.MotorovaDD.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressian()
        {
            DataService ds = new DataService();
            int x = 3;
            object res = ds.sqr();
            Assert.AreEqual(6, res);




        }
    }
}
