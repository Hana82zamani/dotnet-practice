namespace PassengerLibPattern;


public class Passenger
{
    public string Name { get; set; } = "";
}

public class FirstClassPassenger : Passenger
{
    public int AirMiles { get; set; }
}

public class BusinessClassPassenger : Passenger
{
    public int Years { get; set; }
}

public class CoachClassPassenger : Passenger
{
    public double CarryOnKG { get; set; }

}
