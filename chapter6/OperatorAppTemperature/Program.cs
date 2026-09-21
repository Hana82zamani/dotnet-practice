using TemperatureLibOperator;

Temperature temperature1 = new()
{
    Celsius=15
};
Temperature temperature2 = new()
{
    Celsius=20
};
Temperature result=temperature1+temperature2;

Console.WriteLine(result.Celsius);