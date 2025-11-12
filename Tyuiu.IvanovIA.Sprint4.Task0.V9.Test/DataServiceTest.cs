using Tyuiu.IvanovIA.Sprint4.Task0.V9.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] nums = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = ds.GetSumEvenArrEl(nums);
            int wait = 38;
            Assert.AreEqual(res, wait);
        }
    }
}
