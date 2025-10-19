using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BukinTK.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1.0;
            while (startValue <= stopValue)
            {
                result *= (Math.Pow(value, startValue) + 4) * Math.Cos(value);
                startValue++;
            }
            return Math.Round(result, 3);
        }
    }
}
