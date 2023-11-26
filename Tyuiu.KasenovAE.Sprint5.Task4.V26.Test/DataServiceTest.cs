using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint5.Task4.V26.Lib;

namespace Tyuiu.KasenovAE.Sprint5.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_Test()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V26.txt";
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            double clced = 52.842;
            Assert.AreEqual(res, clced);
        }
    }
}
