namespace CarLibPattern;

public class Car
{
    public string Model { get; set; } = "";
}

public class LuxuryCar : Car
{
    public int HorsePower { get; set; }
}

public class FamilyCar : Car
{
    public int Seats { get; set; }
}

public class EconomyCar : Car
{
    public double FuelConsumption { get; set; }
}