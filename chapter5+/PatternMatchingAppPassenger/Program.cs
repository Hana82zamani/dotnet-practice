using PatternMatchingLibPassenger;

Passenger passenger = new EconomyPassenger
{
    ExtraBaggageKG = 18.5m
};

decimal ExteraPrice= passenger switch 
{
    EconomyPassenger { ExtraBaggageKG:>10}=> 
    (passenger.ExtraBaggageKG-10)*200,
    BusinessPassenger {ExtraBaggageKG:>20}=> 
    (passenger.ExtraBaggageKG-20)*150,
    FirstClassPassenger {ExtraBaggageKG:>30}=>0,
    _ => 0 
    
};
Console.WriteLine($"{passenger.ExtraBaggageKG}={ExteraPrice}");