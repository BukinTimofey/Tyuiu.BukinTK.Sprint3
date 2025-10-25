using Tyuiu.BukinTK.Sprint3.Task3.V10.Lib;

namespace Tyuiu.BukinTK.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();

            string str = "gdfppf vfppt p";
            char chr = 'p';

            string wait = "gdff vft ";
            string res = ds.DeleteCharInString(str, chr);

            Assert.AreEqual(wait, res);
        }
    }
}
