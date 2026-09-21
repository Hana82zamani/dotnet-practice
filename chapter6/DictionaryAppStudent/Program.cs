using StudentLibDictionary;

Dictionary<int,Student>students=new();

students.Add(1, new Student
{
    Name = "Hana",
    Score = 95
});

students.Add(2, new Student
{
    Name = "Ali",
    Score = 80
});

students.Add(3, new Student
{
    Name = "Sara",
    Score = 90
});

Console.WriteLine(students[2].Name);

