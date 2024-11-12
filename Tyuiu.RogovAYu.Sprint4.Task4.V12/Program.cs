using System;
using Tyuiu.RogovAYu.Sprint4.Task4.V12.Lib;

namespace Tyuiu.RogovAYu.Sprint4.Task4.V12
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            int[,] result;

            Console.Title = "Task:4.4.v12| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:   Заменить четные элементы массива на 1.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("*  = ");
            int[,] input = new int[5,5];
            for (int i = 0; i <5; i++) {
                for (int j=0;j<5;j++) { input[i,j] = Convert.ToInt32(Console.ReadLine()); } 
            }
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.Calculate(input);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++) { Console.Write($"{result[i,j]}; "); if (j == 4) { Console.WriteLine(); } }
            }
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
