using System;
using System.IO;
using System.Threading;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KasenovAE.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string str = File.ReadAllText(path);
            double x = Convert.ToDouble(str);
            double y = (Math.Pow(x, 3) + Math.Sin(x)) * Math.Cos(x);
            y = Math.Round(y, 3);
            return y;
        }
    }
}
