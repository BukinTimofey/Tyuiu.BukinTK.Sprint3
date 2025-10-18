using Tyuiu.BukinTK.Sprint3.Task0.V5.Lib;

namespace Tyuiu.BukinTK.Sprint3.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int endValue = 10;

            double res = ds.GetSumSeries(startValue, endValue);

            double wait = 81.083;

            Assert.AreEqual(wait, res);
        }
    }
}
