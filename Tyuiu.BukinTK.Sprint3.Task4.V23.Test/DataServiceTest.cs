using Tyuiu.BukinTK.Sprint3.Task4.V23.Lib;

namespace Tyuiu.BukinTK.Sprint3.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTes
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 0;

            double wait = 0;
            double res = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
