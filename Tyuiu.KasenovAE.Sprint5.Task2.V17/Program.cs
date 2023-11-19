using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint5.Task2.V17.Lib;
using System.IO;

namespace Tyuiu.KasenovAE.Sprint5.Task2.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("* результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("* 2; 1; 7                                                                 *");
            Console.WriteLine("* 1; 2; 4                                                                 *");
            Console.WriteLine("* 2; 3; 4                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] mtrx = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Введите [{i}, {j}] элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
