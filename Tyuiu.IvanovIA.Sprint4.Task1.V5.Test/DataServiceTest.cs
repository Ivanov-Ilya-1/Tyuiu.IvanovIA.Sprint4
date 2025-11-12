using Tyuiu.IvanovIA.Sprint4.Task1.V5.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7 };
            int res = ds.Calculate(nums);
            int wait = 60;
            Assert.AreEqual(res, wait);
        }
    }
}
