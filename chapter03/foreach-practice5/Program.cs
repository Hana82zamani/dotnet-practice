int[] numbers =
{
    12,
    8,
    25,
    3,
    17
};

int max = numbers[0];
int min = numbers[0];

foreach (int num in numbers)
{
    if (num > max)
    {
        max=num;
    }
 else if (num < min)
    {
        min=num;
    }


}

Console.WriteLine($"Max = {max}");
Console.WriteLine($"Min = {min}");