int[] numbers =
{
    12,
    8,
    25,
    3,
    17,
    40,
    5,
    18
};
int sum=0;
int evensum=0;
int oddsum=0;
int evencount=0;
int oddcount=0;

foreach(int num in numbers)
{
     sum=num+sum;
    if (num % 2 == 0)
    {
        evensum=num+evensum;
   evencount++;
    }
else if(num % 2 == 1)
    {
        oddsum= num+oddsum;
        oddcount++;
    }


}
Console.WriteLine($"sum :{sum}");
Console.WriteLine($" even sum :{evensum}");
Console.WriteLine($" odd sum:{oddsum}");
Console.WriteLine($"length:{numbers.Length}");
Console.WriteLine($"even count :{evencount}");
Console.WriteLine($" odd count:{oddcount}");