Console.WriteLine($"enter your password: ");
string password=Console.ReadLine()!;
if (password.Length <8 )
{
Console.WriteLine("your password must be more than 8 charcters");
} 
else
{
Console.WriteLine("your password has been accepted");
}