int number;
do
{
    Console.WriteLine("enter a number:");
 number=int.Parse(Console.ReadLine()!);

}
while(number<0);
Console.WriteLine("valid number!");
