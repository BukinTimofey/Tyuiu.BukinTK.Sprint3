using Tyuiu.BukinTK.Sprint3.Task2.V24.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double value = 0.25;
        int startValue = 1;
        int stopValue = 8;

        Console.WriteLine("Переменная A = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));

        Console.ReadKey();
    }
}