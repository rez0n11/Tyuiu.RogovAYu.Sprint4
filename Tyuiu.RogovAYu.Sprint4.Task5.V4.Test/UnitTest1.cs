using Tyuiu.RogovAYu.Sprint4.Task5.V4.Lib;
namespace Tyuiu.RogovAYu.Sprint4.Task5.V4.Test
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[,] input = { { -1, -2, -3, -4, 5 }, { -6, -7, -8, -9, 10 }, { -11, -12, -13, -14, 15 }, { -16, -17, -18, -19, 20 }, { 1, -2, -3, -4, -5 } };
            Assert.AreEqual(5, ds.Calculate(input));
        }
    }
}