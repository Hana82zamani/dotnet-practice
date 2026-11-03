namespace ConstructorLibEmployee;

public class Employee
{
   public string Name{get; set;}="";
   public decimal Salary{get;set;}

   public Employee()
   : this("unknown",0m)
   {
   }
   public Employee (string name)
   : this(name,0)
    {
        
    }
    public Employee(string name , decimal salary)
    {
        Name=name;
        Salary=salary;
    }

}
