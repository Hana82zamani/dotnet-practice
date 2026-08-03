Console.WriteLine("enter your score:");
double score = double.Parse(Console.ReadLine()!);
if (score >= 18)
{
    Console.WriteLine("Excellent");
}
else if( score <=17 && score >=10)
{
    Console.WriteLine("passed");
}
else 
{
    Console.WriteLine("failed");
}