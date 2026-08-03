int sum=0;

for(int i = 1; i <= 5; i++)
{
    Console.WriteLine("Enter a number :");
    int x=int.Parse(Console.ReadLine()!);
    
  sum=x+sum;
}

double ave= (double)sum/5;
Console.WriteLine($"sum of numbers : {sum}");
Console.WriteLine($"averge of numbers : {ave}");
