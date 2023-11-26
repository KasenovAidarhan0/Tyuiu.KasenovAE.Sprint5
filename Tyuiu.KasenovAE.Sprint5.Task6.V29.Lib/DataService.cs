using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KasenovAE.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] words = text.Split(' ');
            int c = 0;
            foreach (string word in words)
            {
                if (word.Length == 7)
                {
                    c++;
                }
            }
            return c;
        }
    }
}
