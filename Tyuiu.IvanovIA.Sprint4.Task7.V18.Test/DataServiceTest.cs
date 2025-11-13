using Tyuiu.IvanovIA.Sprint4.Task7.V18.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n, m;
            n = 5; m = 3;
            string value = "145258749635789";
            int wait = 12288;
            int res = ds.Calculate(n, m, value);
            Assert.AreEqual(wait, res);
        }
    }
}
