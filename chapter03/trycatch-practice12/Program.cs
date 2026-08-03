Console.Write("enter a number :");
string number1=Console.ReadLine()!;
Console.Write("enter a number :");
string number2=Console.ReadLine()!;
Console.Write("enter a number:");
string number3=Console.ReadLine()!;
try
{
 int num1=int.Parse(number1);
 int num2=int.Parse(number2);
 int num3=int.Parse(number3);

    checked
    {
        int multi=num1*num2*num3;
        Console.WriteLine($"Multiplication= {multi}");
    }
}
catch(OverflowException)
{
    Console.WriteLine("the result is too large");
    
}