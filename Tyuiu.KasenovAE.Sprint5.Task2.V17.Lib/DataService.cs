using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KasenovAE.Sprint5.Task2.V17.Lib
{
    public class DataService : ISprint5Task2V17
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int res;
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";
            if (File.Exists(path))
                File.Delete(path);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res = matrix[i, j];
                    if (res % 2 != 0)
                        res = 0;
                    string cont = Convert.ToString(res);
                    if (j != n - 1)
                        cont += ';';
                    File.AppendAllText(path, cont);
                }
                if (i != m - 1)
                    File.AppendAllText(path, Environment.NewLine);
            }
            return path;
        }
    }
}
