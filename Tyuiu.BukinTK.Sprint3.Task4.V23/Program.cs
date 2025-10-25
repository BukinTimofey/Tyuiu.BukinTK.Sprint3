using Tyuiu.BukinTK.Sprint3.Task4.V23.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int endValue = -5;
        int stopValue = 0;

        Console.WriteLine("Промежуток от " + startValue + " До " + endValue);
        Console.WriteLine("Число на котором нужно остановиться = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(startValue, stopValue));

        Console.ReadKey();
    }
}