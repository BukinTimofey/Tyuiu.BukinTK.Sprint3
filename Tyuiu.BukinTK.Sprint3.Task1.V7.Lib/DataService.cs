using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BukinTK.Sprint3.Task1.V7.Lib
{
    public class DataService : ISprint3Task1V7
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1.0;
            while (startValue <= stopValue)
            {
                result *= (Math.Pow(value, startValue) + 1) * Math.Sin(5);
                startValue++;
            }
            return Math.Round(result, 3);
        }
    }
}
