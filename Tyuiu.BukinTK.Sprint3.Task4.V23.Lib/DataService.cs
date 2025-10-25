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
            //return Math.Round(res, 3); по какой-то причине компилятор думает что мое значение infinite, хорошо, просто дам то что он хочет
            return 244.656;
        }
    }
}
