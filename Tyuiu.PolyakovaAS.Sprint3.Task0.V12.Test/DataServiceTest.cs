using Tyuiu.PolyakovaAS.Sprint3.Task0.V12.Lib;
namespace Tyuiu.PolyakovaAS.Sprint3.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 13;

            var res = ds.GetMultiplySeries(startValue, stopValue, value);

            Assert.AreEqual(1, res);
        }
    }
}
