namespace VehicleLibGenericConstraint;

public class Vehicle
{
    public string Brand = "";
 
public class Car : Vehicle
{
    
}
 public class Bike : Vehicle
{
    
}

public static void ShowBrand<T>(T vehicle)where T : Vehicle
    {
        Console.WriteLine($"brand : {vehicle.Brand}") ;
    }//  where T: baseclass استفاده از 
}
