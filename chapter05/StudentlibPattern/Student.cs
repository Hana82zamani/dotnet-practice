namespace StudentLibPattern;

public class Student
{
    public string Name { get; set; } = "";
}

public class SchoolStudent : Student
{
    public int Age { get; set; }
    public int Score { get; set; }
}

public class UniversityStudent : Student
{
    public int Credits { get; set; }
    public double GPA { get; set; }
}