using StudentIdLib2;

StudentId studentId=new();

var (Name,score)=studentId.GetStudent();

Console.WriteLine($"name:{Name}, score: {score}");