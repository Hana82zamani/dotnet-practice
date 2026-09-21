namespace TemperatureLibOperator;

public class Temperature
{
    public double Celsius;

    public static Temperature operator+(Temperature temperature1, Temperature temperature2)
    {
     return new Temperature
     {
         Celsius=temperature1.Celsius+temperature2.Celsius
     };

    }

}
