using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KasenovAE.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string savePath = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V10.txt";
            string alph = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string allText = File.ReadAllText(path);
            string retText = "";
            for (int i = 0; i < allText.Length; i++)
            {
                if (alph.Contains(allText[i]))
                {
                    string v = Convert.ToString(allText[i]).ToLower();
                    retText += v;
                    continue;
                }
                retText += allText[i];
            }
            File.AppendAllText(savePath, retText);
            return savePath;
        }
    }
}
