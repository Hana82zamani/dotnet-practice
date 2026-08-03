Console.Write("enter your age:");
string input= Console.ReadLine()!;
try
{
    int age=int.Parse(input);
    Console.WriteLine($"you are {age} yearsold");

}
catch
{
    Console.WriteLine("Invalid age ! Pleas enter your age again:");
}