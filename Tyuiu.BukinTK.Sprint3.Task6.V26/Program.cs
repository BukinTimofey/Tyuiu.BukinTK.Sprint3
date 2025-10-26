using Tyuiu.BukinTK.Sprint3.Task6.V26.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        int startValue = 15;
        int stopValue = 22;

        Console.WriteLine("Промежуток от " + startValue + " До " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Кол-во делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

        Console.ReadKey();
    }
}