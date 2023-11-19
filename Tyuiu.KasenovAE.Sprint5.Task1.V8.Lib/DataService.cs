using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KasenovAE.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            double Y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                Y = 4.0 - 2.0 * x + ((2.0 + Math.Cos(x)) / (2.0 * x - 2.0));
                Y = Math.Round(Y, 2);
                strY = Convert.ToString(Y);
                if ((2.0 * x - 2.0) == 0)
                {
                    strY = "0";
                }
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
