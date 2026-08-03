Console.Write("enter first number:");
string num1 = Console.ReadLine()!;
Console.Write("enter the second number:");
string num2 = Console.ReadLine()!;



try
{
    int number1=int.Parse(num1); 
    int number2=int.Parse(num2); 

     int sum = number1+number2 ;
     
Console.WriteLine($"sum= {sum}");

}
catch
{
    Console.WriteLine("invalid number !");
}

