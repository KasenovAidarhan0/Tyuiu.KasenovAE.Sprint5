using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KasenovAE.Sprint5.Task7.V10.Lib;

namespace Tyuiu.KasenovAE.Sprint5.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FileExists()
        {
            string path = @"C:\Users\kasen\source\repos\Tyuiu.KasenovAE.Sprint5\Tyuiu.KasenovAE.Sprint5.Task7.V10\bin\Debug\OutPutDataFileTask7V10.txt";
            bool res = File.Exists(path);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
