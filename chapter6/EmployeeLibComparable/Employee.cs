namespace EmployeeLibComparable;

public class Employee : IComparable<Employee>
{
    public string Name = "";
    public int Age;

    public int CompareTo(Employee? other)
    {
        if (other is null)return 1;

      int resilt = Age.CompareTo(other.Age);

      if (resilt == 0)
        {
            return Name.CompareTo(other.Name);
        }

        return resilt;
    }

}
