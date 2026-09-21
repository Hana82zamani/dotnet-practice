using EmployeeLibComparable;

Employee[] employees =
{
    new Employee
    {
        Name="Ali",
        Age=22
    },
    new Employee
    {
        Name="Hana",
        Age=21
    },
    new Employee
    {
        Name="Sara",
        Age=25
    },
    new Employee
    {
        Name="Reza",
        Age=25
    },
    
};
Array.Sort(employees);

foreach(Employee employee in employees)
{
    Console.WriteLine(employee.Name);
}