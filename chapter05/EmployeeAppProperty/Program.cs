using EmployeeLibProperty;

Employee employee=new();

try
{
    employee.Name="Hana";
    employee.Salary=1000;

    Console.WriteLine(employee.Name);
    Console.WriteLine(employee.Salary);

}
catch(AggregateException ex)
{
    Console.WriteLine(ex.Message);
}
