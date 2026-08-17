using EmployeeLibStatic;

Employee employee1 = new()
{
    Name= "Ali",
    Salary=5000,

};
Employee employee2 = new()
{
    Name= "Sara",
    Salary=7000,

};

 Employee.CompanyName = "Microsoft";
 Employee.EmployeeCount=2;

 Console.WriteLine($"{employee1.Name} at {Employee.CompanyName} earns {employee1.Salary}");
 Console.WriteLine($"{employee2.Name} at {Employee.CompanyName} earns {employee2.Salary}");
Console.WriteLine($"totaly employees:{Employee.EmployeeCount}");