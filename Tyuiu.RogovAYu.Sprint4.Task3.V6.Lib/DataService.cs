using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RogovAYu.Sprint4.Task3.V6.Lib
{
    public class DataService : ISprint4Task3V6
    {
        public int Calculate(int[,] array)
        {
            int a=0;
            for (int i = 0; i < 5; i++) 
            {
                if (a < array[1, i]) { a = array[1, i]; }
            }
            return a;
        }
    }
}
