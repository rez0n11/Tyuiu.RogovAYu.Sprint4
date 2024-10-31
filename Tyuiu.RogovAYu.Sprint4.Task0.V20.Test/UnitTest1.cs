using Tyuiu.RogovAYu.Sprint4.Task0.V20.Lib;
namespace Tyuiu.RogovAYu.Sprint4.Task0.V20.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(24576, ds.GetMultEvenArrEl( [ 4 ,8 ,7 ,6 ,5 ,8 ,2 ,4 ,3 ,2]));
        }
    }
}