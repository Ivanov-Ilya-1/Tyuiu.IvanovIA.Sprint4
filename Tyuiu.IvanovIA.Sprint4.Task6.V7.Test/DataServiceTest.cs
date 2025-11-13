using Tyuiu.IvanovIA.Sprint4.Task6.V7.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика" };
            int res = ds.Calculate(array);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
