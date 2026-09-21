namespace CalculatorLibGenericWhere;

public class Calculator
{
    public static T show<T>(T number) where T : struct
    {
        return number;
    }

}
