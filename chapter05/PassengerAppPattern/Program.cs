using PassengerLibPattern;

Passenger[] passengers =
{
    new FirstClassPassenger
    {
        Name = "Hana",
        AirMiles = 40000
    },

    new FirstClassPassenger
    {
        Name = "Ali",
        AirMiles = 12000
    },

    new BusinessClassPassenger
    {
        Name = "Sara",
        Years = 6
    },

    new CoachClassPassenger
    {
        Name = "Mina",
        CarryOnKG = 5
    },

    new CoachClassPassenger
    {
        Name = "Reza",
        CarryOnKG = 20
    }
};

foreach (Passenger passenger in passengers)
{
    decimal price = passenger switch
    {
       FirstClassPassenger F when F.AirMiles>30000 => 1500,
       FirstClassPassenger F when F.AirMiles>10000=> 1750,
       FirstClassPassenger _ => 2000,
       BusinessClassPassenger B when B.Years >5 => 900,
       BusinessClassPassenger _ => 1000,
       CoachClassPassenger C when C.CarryOnKG<10 => 500,
       CoachClassPassenger =>650,
       _ =>800

    };

    Console.WriteLine($"{passenger.Name}: {price}");
}