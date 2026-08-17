namespace EmployeeLibIndex;

public class Employee
{
    private string _name="";
    private decimal _salary;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(" enter name");
            }

            _name=value;
        }
    }
    public decimal Salary
    {
        get
        {
            return _salary;
        }
        set
        {
            if (value<0)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }
            _salary=value;
        }
    }

}
public class Company
{
    public List<Employee> Employees = new();
    
    public Employee this[string name]
    {
        get
        {
            return Employees.Find(C=> C.Name==name);
        }
        
    }
}