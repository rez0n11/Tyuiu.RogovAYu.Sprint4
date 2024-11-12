﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RogovAYu.Sprint4.Task4.V12.Lib
{
    public class DataService : ISprint4Task4V12
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]%2==0) { matrix[i, j] = 1; }
                }
            }
            return matrix;
        }
    }
}
