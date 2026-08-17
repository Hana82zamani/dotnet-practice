using StudentLib2;

Student student =new();

var (score,status)= student.GetResult(18);


Console.WriteLine($"the score is {score} {status}");