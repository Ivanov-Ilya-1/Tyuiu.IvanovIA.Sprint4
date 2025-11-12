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
            int[] nums = { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6};
            int res = ds.Calculate(nums);
            int wait = 39;
            Assert.AreEqual(res, wait);
        }
    }
}
