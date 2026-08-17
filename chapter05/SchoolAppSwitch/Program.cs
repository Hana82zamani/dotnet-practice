using SchoolLibrary;

Student student1 = new()
{
    StudentName = "Hana",

    StudentAge =22
};

Student student2 = new()
{
    StudentName = "Ali",

    StudentAge =22
};

Student student3 = new()
{
    StudentName = "sara",

    StudentAge =21
};

Classroom classroom = new()
{
    name="Engclass",

};

classroom.students.Add(student1);
classroom.students.Add(student2);
classroom.students.Add(student3);

Console.WriteLine($"Class: {classroom.name}");

foreach (Student student in classroom.students)
{
    Console.WriteLine($"{student.StudentName} - {student.StudentAge}");
}