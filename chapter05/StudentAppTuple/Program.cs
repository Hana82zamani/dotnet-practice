using StudentLib4;

Student student=new();
var (score,status)=student.GetResult(13);
Console.WriteLine($"{score},{status}");