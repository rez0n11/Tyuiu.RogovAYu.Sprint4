using System;
using Tyuiu.RogovAYu.Sprint4.Task1.V21.Lib;

namespace Tyuiu.RogovAYu.Sprint4.Task1.V21
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            int result;
            int[] input = new int[11];

            Console.Title = "Task:4.1.v21| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:Произведение четных элементов массива[11]                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            for (int i = 0; i <= 10; i++) { input[i] = Convert.ToInt32(Console.ReadLine()); }
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
