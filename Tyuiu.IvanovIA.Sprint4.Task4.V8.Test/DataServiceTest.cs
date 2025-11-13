using Tyuiu.IvanovIA.Sprint4.Task4.V8.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dataservice ds = new Dataservice();
            int[,] nums = new int[5, 5]
            {   { 1, 3, 2, 2, 5 },
                { 6, 1, 5, 5, 2 },
                { 1, 5, 4, 1, 4 },
                { 4, 1, 4, 4, 5 },
                { 4, 6, 1, 1, 4 } };

            int[,] wait = new int[5, 5]
            {   { 1, 3, 1, 1, 5 },
                { 1, 1, 5, 5, 1 },
                { 1, 5, 1, 1, 1 },
                { 1, 1, 1, 1, 5 },
                { 1, 1, 1, 1, 1 } };



            int[,] res = ds.Calculate(nums);

            CollectionAssert.AreEqual(nums, res);





        }
    }
}
