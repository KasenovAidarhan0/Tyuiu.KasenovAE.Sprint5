using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KasenovAE.Sprint5.Task1.V8.Lib;

namespace Tyuiu.KasenovAE.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckResult()
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(startValue, stopValue);
            double[] arr1 = new double[] { 13.81, 11.87, 9.87, 7.74, 5.36, 2.5, 0, 0.79, -1.75, -3.78, -5.71 };
            double[] arr2 = new double[arr1.GetLength(0)];
            double fx;
            int c = 0; 
            foreach (string line in File.ReadAllLines(path))
            {
                fx = Convert.ToDouble(line);
                arr2[c] = fx;
                c++;
            }
            CollectionAssert.AreEqual(arr1, arr2);
        }
    }
}
