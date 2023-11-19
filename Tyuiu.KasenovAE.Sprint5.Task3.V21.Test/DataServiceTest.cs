using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint5.Task3.V21.Lib;
using System.IO;

namespace Tyuiu.KasenovAE.Sprint5.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExists()
        {
            string path = @"C:\Users\kasen\source\repos\Tyuiu.KasenovAE.Sprint5\Tyuiu.KasenovAE.Sprint5.Task3.V21\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
