using EmployeeLibIndex;

Company company=new();
try
{
Employee employee1 = new()
{
    Name="Hana",
    Salary=1000
};
Employee employee2 = new()
{
    Name="Ali",
    Salary=1500
};
Employee employee3 = new()
{
    Name="Sara",
    Salary=2000
};


    company.Employees.Add(employee1);
    company.Employees.Add(employee2);
    company.Employees.Add(employee3);

    Console.WriteLine(company["Hana"].Salary);
    Console.WriteLine(company["Sara"].Salary);
    
}catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}