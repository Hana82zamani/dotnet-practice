Console.Write("enter a number:");
string number=Console.ReadLine()!;
try
{
    int num=int.Parse(number);
    checked
    {
        for(int i = 1; i <= num; i++)
        {
            
            Console.WriteLine(i);
        }
        
    }
}
catch (OverflowException)
{
    Console.WriteLine("number is overflow!");
}
