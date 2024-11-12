using System;
using Tyuiu.RogovAYu.Sprint4.Task5.V4.Lib;

namespace Tyuiu.RogovAYu.Sprint4.Task5.V4
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            int result;
            Random rd = new();

            Console.Title = "Task:4.5.v4| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            int rows= Convert.ToInt32(Console.ReadLine());  int cols = Convert.ToInt32(Console.ReadLine());
            int[,] input = new int[rows,cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    input[i, j] = rd.Next(-4,6);
                    Console.Write($"{input[i, j]}; ");
                    if (j == cols - 1) { Console.WriteLine(); }
                }
            }
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.Calculate(input);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Ответ = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
