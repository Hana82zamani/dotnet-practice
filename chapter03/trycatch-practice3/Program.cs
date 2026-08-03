int sum =0;
double ave = 0;
Console.Write("enter first nuber:");
string num1=Console.ReadLine()!;
 Console.Write("enter the second nuber:");
string num2=Console.ReadLine()!;
Console.Write("enter the third nuber:");
string num3=Console.ReadLine()!;

try
{
int number1=int.Parse(num1);
int number2=int.Parse(num2);
int number3=int.Parse(num3);

 sum= number1+number2+number3;
 Console.WriteLine($"sum={sum}");
ave=(double)sum/3;
Console.WriteLine($"averge={ave}");

}
    catch
    {
        Console.WriteLine("Ivalid number! try again");
    }



