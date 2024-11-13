using Tyuiu.RogovAYu.Sprint4.Task7.V5.Lib;
namespace Tyuiu.RogovAYu.Sprint4.Task7.V5.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(4,ds.Calculate(3,3,"246813579"));
        }
    }
}