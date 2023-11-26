using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KasenovAE.Sprint5.Task5.V25.Lib
{
    public class DataService : ISprint5Task5V25
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] lines = text.Split('\n');
            double res = 1;
            foreach (string line in lines)
            {
                res *= Convert.ToDouble(line);
            }
            res = Math.Round(res, 3);
            return res;
        }
    }
}
