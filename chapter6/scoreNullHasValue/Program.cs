int? Score=null;

Console.WriteLine(Score.HasValue);

if (Score is null)
{
    Console.WriteLine("No value");
}

Score=18;
Console.WriteLine(Score);