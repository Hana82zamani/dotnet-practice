namespace PrinterGenericWhere;

public class Printer
{

    public static void Print<T>(T value) where T : class
    {
        Console.WriteLine(value);
    }

}
