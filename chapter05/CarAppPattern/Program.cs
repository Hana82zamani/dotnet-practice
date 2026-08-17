using CarLibPattern;

Car[] cars =
{
    new LuxuryCar
    {
        Model = "BMW",
        HorsePower = 450
    },

    new LuxuryCar
    {
        Model = "Mercedes",
        HorsePower = 250
    },

    new FamilyCar
    {
        Model = "Toyota",
        Seats = 7
    },

    new FamilyCar
    {
        Model = "Peugeot",
        Seats = 5
    },

    new EconomyCar
    {
        Model = "Pride",
        FuelConsumption = 6.5
    },

    new EconomyCar
    {
        Model = "Samand",
        FuelConsumption = 9.5
    }
};
foreach (Car car in cars)
{
    decimal price = car switch
    {
       LuxuryCar {HorsePower: >400 }=> 80000,
       LuxuryCar {HorsePower:>200}=> 60000,
       LuxuryCar =>50000,
       FamilyCar {Seats :>=7}=> 40000,
       FamilyCar =>30000,
       EconomyCar{FuelConsumption:<7}=>20000,
       EconomyCar =>25000,
       _ =>10000

    };

    Console.WriteLine($"{car.Model}: {price}");
}