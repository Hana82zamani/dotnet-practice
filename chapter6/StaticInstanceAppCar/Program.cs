using CarLibStaticInstance;

Car car1 = new()
{
  Brand="BMW", 
  Price= 5000

};
Car car2 = new()
{
  Brand="Toyota", 
  Price= 3000

};

Console.WriteLine(car2.GetPrice());

Console.WriteLine(car1.GetPrice()); // use instance

 Console.WriteLine(Car.GetPrice(car1)); // use static