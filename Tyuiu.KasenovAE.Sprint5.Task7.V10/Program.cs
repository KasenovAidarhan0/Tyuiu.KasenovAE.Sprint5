using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.KasenovAE.Sprint5.Task7.V10.Lib;

namespace Tyuiu.KasenovAE.Sprint5.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask7V10.txt (файл взять из архива *");
            Console.WriteLine(@"* согласно вашему варианту. Создать папку в ручную С:\DataSprint5\        *");
            Console.WriteLine("* и скопировать в неё файл) в котором есть набор символьных данных        *");
            Console.WriteLine("* Заменить все заглавные латинские буквы на строчные.                     *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V10.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V10.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string savePath = ds.LoadDataAndSave(path);
            Console.WriteLine("Находится в файле: ");
            Console.WriteLine(savePath);
            Console.ReadKey();
        }
    }
}
