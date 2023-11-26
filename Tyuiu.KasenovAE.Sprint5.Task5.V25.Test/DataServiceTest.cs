using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint5.Task5.V25.Lib;
using System.IO;

namespace Tyuiu.KasenovAE.Sprint5.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V25.txt";
            bool res = File.Exists(path);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
