using VehicleLibPattern; 

Vehicle[] vehicles =
{
    new ElectricCar
    {
        model="tesla",
        BatteryPercent= 80

    },
     new ElectricCar
    {
        model="Nissan",
        BatteryPercent= 30

    },

     new GasCar
    {
        model="BMW",
        FuelLiters= 50

    },
    new GasCar
    {
        model="Pride",
        FuelLiters= 10

    },
    new Motorcycle
    {
        model="BMW",
        EngineCC = 600

    },
    
};
foreach(Vehicle vehicle in vehicles)
{
  string status = vehicle switch
  {
      ElectricCar {BatteryPercent: >=50}=> "ready",
      ElectricCar{BatteryPercent:<50}=> "needed charge",
      GasCar{FuelLiters:>=20}=>"enghof fuel",
      GasCar{FuelLiters:<20}=>"low fuel",
      Motorcycle{EngineCC:>=500}=> "powerfull",
      Motorcycle{EngineCC:<500}=> "normal",
      _ =>"unknown"

  };

  Console.WriteLine($"{vehicle.model} : {status}");

}
