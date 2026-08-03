Console.Write("enter a number :");
string number=Console.ReadLine()!;
try
{
    int num=int.Parse(number);
    Console.WriteLine(num);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}