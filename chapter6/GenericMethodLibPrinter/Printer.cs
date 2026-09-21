namespace PrinterLibGenericMethod;

public class Printer
{
  public static void Print<T>(T value)
    {
        Console.WriteLine(value);
    }

}
