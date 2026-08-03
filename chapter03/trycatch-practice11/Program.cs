Console.Write("enter a number :");
string number1=Console.ReadLine()!;
Console.Write("enter a number :");
string number2=Console.ReadLine()!;
try
{
    int num1=int.Parse(number1);
    int num2=int.Parse(number2);

    
    checked
    {
        int sum=num1+num2;
    Console.WriteLine($"sum={sum}");
    }

}
catch (OverflowException)
{
    Console.WriteLine("the number which you entered is too large");

}