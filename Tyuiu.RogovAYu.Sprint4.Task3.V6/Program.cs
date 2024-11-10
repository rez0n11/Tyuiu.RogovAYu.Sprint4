using System;
using Tyuiu.RogovAYu.Sprint4.Task3.V6.Lib;

namespace Tyuiu.RogovAYu.Sprint4.Task3.V6
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            int result;

            Console.Title = "Task:4.3.v6| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:  Найдите максимальный элемент во второй строке массива.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            int[,] ints = {
                            { 8, 8, 3, 4, 5 },
                            { 8, 6, 6, 4, 6 },
                            { 3, 6, 5, 3, 4 },
                            { 5, 6, 3, 7, 5 },
                            { 7, 8, 5, 6, 6 }
                          };
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(ints[i,j]+",");
                }
                Console.WriteLine();

            }
            { //code
                result = ds.Calculate(ints);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
