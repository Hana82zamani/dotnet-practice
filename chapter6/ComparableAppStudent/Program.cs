using StudentLibComparable;

Student[] students =
{
    new Student 
    {
        name="Ali",
        age=22
    },
    new Student
    {
        name="Hana",
        age=21
    },
    new Student
    {
        name="Sara",
        age=25
    }
};
Array.Sort(students);

foreach (Student student in students)
{
    Console.WriteLine(student.name);
}