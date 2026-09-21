namespace DelegateLib;

public delegate int StringCalculator(string text);
public class Calculator
{
    public int GetLength(string word)
    {
        return word.Length;
    }

}
