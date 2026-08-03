int sum=0;

Console.Write("enter a number:");
string? num=Console.ReadLine()!;

Console.Write("enter a number:");
string? num2=Console.ReadLine()!;

if(int.TryParse(num,out int number)&&int.TryParse(num2,out int number2))
{
     sum=number+number2;
     Console.WriteLine(sum);
}
else
{
    Console.WriteLine("error");
}