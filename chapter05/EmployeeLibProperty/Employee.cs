namespace EmployeeLibProperty;

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
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("enter name");
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
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("invalid number");
            }
            _salary=value;
        }
    }

}
