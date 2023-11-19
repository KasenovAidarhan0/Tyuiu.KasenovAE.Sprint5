using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.KasenovAE.Sprint5.Task1.V8.Lib;

namespace Tyuiu.KasenovAE.Sprint5.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2) (произвести       *");
            Console.WriteLine("* табулироваие) f(x) на заданном диапазоне [-5;5] с шагом 1.              *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть        *");
            Console.WriteLine("* значение 0. Результат сохранить в текстовый файл OutPutFileTask1.txt    *");
            Console.WriteLine("* и вывести на консоль в таблицу.                                         *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            int counter = startValue;
            foreach (string line in File.ReadAllLines(path))
            {
                Console.WriteLine("|{0,-10}|{1,-10}|", counter, line);
                counter++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
