using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KasenovAE.Sprint5.Task0.V11.Lib;

namespace Tyuiu.KasenovAE.Sprint5.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\kasen\source\repos\Tyuiu.KasenovAE.Sprint5\Tyuiu.KasenovAE.Sprint5.Task0.V11\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void CheckedResult()
        {
            string path = @"C:\Users\kasen\source\repos\Tyuiu.KasenovAE.Sprint5\Tyuiu.KasenovAE.Sprint5.Task0.V11\bin\Debug\OutPutFileTask0.txt";
            string fileRes = File.ReadAllText(path);
            string res = "-2,556";
            Assert.AreEqual(res, fileRes);
        }
    }
}
