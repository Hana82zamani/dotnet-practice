using ReviewLibVehicle;

Vehicle[] vehicles =
{
    new Car
    {
        
    },
    new Motorcycle
    {
        
    }
};
foreach (Vehicle vehicle in vehicles)
{
    vehicle.Start();

    if (vehicle is Car car)
    {
        car.OpenTrunk();
    }
    if(vehicle is Motorcycle motorcycle)
    {
        motorcycle.Wheelie();
    }
 
};
foreach (Vehicle vehicle in vehicles)
{
    vehicle.Start();

    Motorcycle ? motorcycle= vehicle as Motorcycle;

    if (motorcycle is not null)
    {
        motorcycle.Wheelie();
    }
    
    Car ? car= vehicle as Car;

    if (car is not null)
    {
        car.OpenTrunk();
    }

}