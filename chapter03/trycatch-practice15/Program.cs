Console.Write("enter a number 0 to 255:");
string number1=Console.ReadLine()!;
Console.Write("enter a number 0 to 255:");
string number2=Console.ReadLine()!;
try
{
    int num1=int.Parse(number1);
    int num2=int.Parse(number2);
   
   

    if (num1 > 255 || num2 > 255 ||num1<0 || num2<0)
    {
         Console.WriteLine("please enter number between 0-255");
    }else if(num2==0)
    {
        Console.WriteLine("number 2 shouldn't be zero");
    }

    else
    {
         double div=(double)num1/num2;
        Console.WriteLine($"division={div}"); 
    }
    
}
catch (OverflowException)
{
    Console.WriteLine("please enter number between 0-255");
}
catch (FormatException)
{
    Console.WriteLine("pleas enter number");
}