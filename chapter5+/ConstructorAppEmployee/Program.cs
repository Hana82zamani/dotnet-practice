using ConstructorLibEmployee;

Employee employee=new("hana",100);

Console.WriteLine($"{employee.Name} = {employee.Salary}");

Employee employee1=new();

Console.WriteLine($"{employee1.Name} = {employee1.Salary}");