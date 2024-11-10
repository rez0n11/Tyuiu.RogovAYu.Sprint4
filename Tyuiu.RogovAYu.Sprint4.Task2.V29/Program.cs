using System;
using Tyuiu.RogovAYu.Sprint4.Task2.V29.Lib;

namespace Tyuiu.RogovAYu.Sprint4.Task2.V29
{
    public class Class1
    {
        public static void Main()
        {
            
            DataService ds = new DataService();
            Random rd = new Random();
            int result;

            Console.Title = "Task:4.2.v29| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:  Произведение четных элементов случайного массива              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* Длина массива = ");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[l];
            for (int i = 0; i < l; i++) 
            { 
                input[i] = rd.Next(1, 8); 
                Console.Write($"{input[i]},");
                if (i == l - 1) { Console.Write("\n"); } 
            }
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.Calculate(input);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"*  = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
