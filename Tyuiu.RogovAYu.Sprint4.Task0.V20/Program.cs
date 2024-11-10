using System;
using Tyuiu.RogovAYu.Sprint4.Task0.V20.Lib;

namespace Tyuiu.RogovAYu.Sprint4.Task0.V20
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            int result;

            Console.Title = "Task:4.0.v20| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Произведение четных в элементов в массиве                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* Массив =  {4 ,8 ,7 ,6 ,5 ,8 ,2 ,4 ,3 ,2}                                    *\n ");
            int[] input = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.GetMultEvenArrEl(input);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
