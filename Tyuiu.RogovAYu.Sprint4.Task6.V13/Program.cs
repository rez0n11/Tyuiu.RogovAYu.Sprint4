using System;
using Tyuiu.RogovAYu.Sprint4.Task6.V13.Lib;

namespace Tyuiu.RogovAYu.Sprint4.Task6.V13
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            int result;

            Console.Title = "Task:4.6.v13| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:      подсчитать количество элементов, длина которых больше 4.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дано:\"Ford\", \"Toyota\", \"Honda\", \"Chevrolet\", \"Mercedes\", \"BMW\", \"Audi\"*");
            string[] input = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };

            { //code
                result = ds.Calculate(input);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Ответ = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
