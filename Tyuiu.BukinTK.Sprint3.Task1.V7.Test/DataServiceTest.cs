using Tyuiu.BukinTK.Sprint3.Task1.V7.Lib;

namespace Tyuiu.BukinTK.Sprint3.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 81.083;

            Assert.AreEqual(wait, res);
        }
    }
}
