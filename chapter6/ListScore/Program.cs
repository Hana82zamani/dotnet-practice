using System.Collections.Generic;

List<double> Scores = new ();

Scores.Add(12.5);
Scores.Add(18.2);
Scores.Add(20);
Scores.Add(9.5);

foreach (double score in Scores)
{
    Console.WriteLine(score);
}