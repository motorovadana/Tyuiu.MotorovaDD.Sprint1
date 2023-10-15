using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MotorovaDD.Sprint1.Task6.V13.Lib;



namespace Tyuiu.MotorovaDD.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressian()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckWordsAlphabet("abcdefg"));

        }
    }
}
