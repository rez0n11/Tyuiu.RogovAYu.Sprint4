using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RogovAYu.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            string[] a = Array.FindAll(array, x => x.Length > 4);
            return a.Length;
        }
    }
}
