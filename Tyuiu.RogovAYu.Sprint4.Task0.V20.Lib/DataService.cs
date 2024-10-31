using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RogovAYu.Sprint4.Task0.V20.Lib
{
    public class DataService : ISprint4Task0V20
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int p = 1;
            foreach (int i in array) { if (array[i] % 2 == 0) { p *= array[i]; } }
            return p;
        }
    }
}
