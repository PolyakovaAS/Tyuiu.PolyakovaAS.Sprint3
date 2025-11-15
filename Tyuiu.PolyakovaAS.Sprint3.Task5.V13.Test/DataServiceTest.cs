using Tyuiu.PolyakovaAS.Sprint3.Task5.V13.Lib;
namespace Tyuiu.PolyakovaAS.Sprint3.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetSumSumSeries(5, 1, 4, 1, 11), 32.269);
        }
    }
}
