using StudentLibIndex;

StudentList student=new();

student.students.Add("Ali");
student.students.Add("Hana");
student.students.Add("Sara");

Console.WriteLine(student[0]);
Console.WriteLine(student[1]);
Console.WriteLine(student[2]);

student[2]="Mina";
Console.WriteLine(student[2]);