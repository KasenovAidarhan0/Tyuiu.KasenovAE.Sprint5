using System;
using Tyuiu.KasenovAE.Sprint5.Task4.V26.Lib;

namespace Tyuiu.KasenovAE.Sprint5.Task4.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask4V0.txt (файл взять из архива  *");
            Console.WriteLine(@"* согласно вашему варианту. Создать папку в ручную С:\DataSprint5\        *");
            Console.WriteLine("* и скопировать в неё файл) в котором есть вещественное значение.         *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле             *");
            Console.WriteLine("* y = (x^3 + sin(x)) * cos(x)                                             *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить            *");
            Console.WriteLine("* до трёх знаков после запятой) и вернуть полученный результат на консоль *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask4V26.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

