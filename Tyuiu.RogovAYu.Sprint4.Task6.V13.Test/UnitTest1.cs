using Tyuiu.RogovAYu.Sprint4.Task6.V13.Lib;
namespace Tyuiu.RogovAYu.Sprint4.Task6.V13.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string[] input = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            Assert.AreEqual(4,ds.Calculate(input));
        }
    }
}