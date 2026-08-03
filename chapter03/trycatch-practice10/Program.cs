Console.Write("enter a number:");
string number =Console.ReadLine()!;
try
{
 int num=int.Parse(number);
    checked
    {

        num++;

    }
    Console.WriteLine(num);

}
catch (OverflowException)
{
    Console.WriteLine("your number is very big!");
}