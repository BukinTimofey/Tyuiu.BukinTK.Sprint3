using Tyuiu.BukinTK.Sprint3.Task3.V10.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string str = "gdfppf vfppt p";
        char chr = 'p';

        Console.WriteLine("Весь текст = " + str);
        Console.WriteLine("Буква которую надо удалить = " + chr);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.DeleteCharInString(str,chr));

        Console.ReadKey();
    }
}