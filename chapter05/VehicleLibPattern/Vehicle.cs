namespace VehicleLibPattern;

public class Vehicle
{
    public string model {get; set;}="";

}
public class ElectricCar : Vehicle
{
    public int BatteryPercent{get; set;}
}
public class GasCar : Vehicle
{
    public int FuelLiters{get; set;}
}
public class Motorcycle: Vehicle
{
    public int EngineCC {get; set;}
}
