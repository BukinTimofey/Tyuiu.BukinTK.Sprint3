using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BukinTK.Sprint3.Task6.V26.Lib
{
    public class DataService : ISprint3Task6V26
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int divisorsCount = 0;
            for (int number = startValue; number <= stopValue; number++)
            {
                for (int divisor = 1; divisor <= number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        divisorsCount++;
                    }
                }
            }
            return divisorsCount;
        }
    }
}
