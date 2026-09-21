namespace VehicleLibInheritance;

public class Vehicle
{
    public string Brand ="";

    public void ShowBrand()
    {
        Console.WriteLine(Brand);
    }

}

public class Motorcycle : Vehicle
{
    public int EngineCC;

    public void ShowEngineCC()
    {
        Console.WriteLine($"Engine: {EngineCC}");
    }
    
}
