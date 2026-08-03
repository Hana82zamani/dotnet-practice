try
{
    checked
    {
        int x= int.MaxValue;
        x++;
    }

}
catch (OverflowException)
{
    Console.WriteLine("your number is very big!");
}
