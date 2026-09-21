namespace CalculatorLibMulticastDelegate;

public class Calculator
{
   public void ShowName(string name)
    {
        Console.WriteLine("Hana");
    }
public void ShowUpper(string name)
    {
        Console.WriteLine("HANA");
    }

}

public delegate void StringPrinter(string text);