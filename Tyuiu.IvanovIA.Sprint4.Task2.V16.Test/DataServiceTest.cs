using Tyuiu.IvanovIA.Sprint4.Task2.V16.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 3, 8, 5, 7, 9, 2, 2, 6, 2, 9 };
            int res = ds.Calculate(nums);
            int wait = 33;
            Assert.AreEqual(res, wait);
        }
    }
}
