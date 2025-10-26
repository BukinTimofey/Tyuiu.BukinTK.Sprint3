using Tyuiu.BukinTK.Sprint3.Task6.V26.Lib;

namespace Tyuiu.BukinTK.Sprint3.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 15;
            int stopValue = 22;

            int wait = 33;
            double res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
