Console.Write("enter a number:");
string? num=Console.ReadLine()!;
if (int.TryParse(num,out int number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("error! Try again");

}