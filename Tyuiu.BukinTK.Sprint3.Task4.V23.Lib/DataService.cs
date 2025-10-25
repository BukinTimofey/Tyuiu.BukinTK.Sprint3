using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BukinTK.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1.0;
            for (startValue = -5; startValue <= 5; startValue++)
            {
                if (startValue == stopValue)
                {
                    break;
                }
                res *= (Math.Cos(startValue) / startValue) + 3; ;
            }
            return Math.Round(res, 3);
        }
    }
}
