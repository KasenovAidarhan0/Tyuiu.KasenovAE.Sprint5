using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint5.Task6.V29.Lib;

namespace Tyuiu.KasenovAE.Sprint5.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_Test()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V29.txt";
            int res = ds.LoadFromDataFile(path);
            int w = 3;
            Assert.AreEqual(w, res);
        }
    }
}
