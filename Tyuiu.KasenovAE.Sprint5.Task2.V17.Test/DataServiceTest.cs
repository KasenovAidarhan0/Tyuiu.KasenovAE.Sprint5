using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint5.Task2.V17.Lib;
using System.IO;

namespace Tyuiu.KasenovAE.Sprint5.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckResult()
        {
            int[,] arr = new int[,] { { 2, 1, 7 },
                                      { 1, 2, 4 },
                                      { 2, 3, 4 } };
            int[,] rarr = new int[,] { { 2, 0, 0 }, 
                                       { 0, 2, 4 },
                                       { 2, 0, 4 } };
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(arr);
            string[] a = new string[3];
            int c = 0;
            foreach (string line in File.ReadAllLines(path))
            {
                a = line.Split(';');
                for (int i = 0; i < 3; i++)
                {
                    arr[c, i] = Convert.ToInt32(a[i]);
                }
                c++;
            }
            CollectionAssert.AreEqual(arr, rarr);
        }
    }
}
