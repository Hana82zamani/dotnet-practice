Console.Write("enter a number :");
string number=Console.ReadLine()!;
try
{
    int num=int.Parse(number);
    Console.WriteLine(num);
}
catch(FormatException) when (number.Contains("$"))
{
    Console.WriteLine(" dot use $ .");
}
catch(FormatException)
{
    Console.WriteLine("enter number.");
}