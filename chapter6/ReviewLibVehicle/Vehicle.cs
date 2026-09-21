namespace ReviewLibVehicle;

public class Vehicle
{
   public virtual void Start()
    {
        Console.WriteLine("vehicle started");
    }

}
public class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car started");
    }

    public void OpenTrunk()
    {
       
    }
}
public class Motorcycle: Vehicle
{
        public override void Start()
    {
        Console.WriteLine("Motorcycle started");
    }

    public void Wheelie()
    {
        
    }
}