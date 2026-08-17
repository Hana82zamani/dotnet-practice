using StudentLib;

Student student =new()
{
    Name= "Hana",
    StudentId= 369,
    
};


Console.WriteLine($"Name: {student.Name}");
Console.WriteLine($"StudentId:{student.StudentId}");
Console.WriteLine($"Email:{student.Email}");
Console.WriteLine($"University:{Student.University}");
Console.WriteLine($"Contry:{Student.Country}");
Console.WriteLine($"Planet:{student.Planet}");