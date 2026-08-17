using ScoreManagerLib;

int number=50;

ScoreManager.AddScore(ref number);

Console.WriteLine(number);

ScoreManager.GetBonus(out int result);

Console.WriteLine(result);


