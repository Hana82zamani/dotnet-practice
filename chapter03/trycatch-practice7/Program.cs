Console.Write("enter a number:");
string number=Console.ReadLine()!;
try
{
    int num=int.Parse(number);
    Console.WriteLine(num);
}
catch (OverflowException)
{
    Console.WriteLine("The number is too large.");
}
catch (FormatException)
{
    Console.WriteLine("Please enter numbers only.");

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}