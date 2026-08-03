int attempts =0;
int number=0;
do
{
    Console.WriteLine("enter password:");
    number=int.Parse(Console.ReadLine()!);
attempts++;
}
while(attempts <3 && number!=1234);
if (1234 == number)
{
    Console.WriteLine("wellcome ");
}else
{
    Console.WriteLine("Access denied");
}