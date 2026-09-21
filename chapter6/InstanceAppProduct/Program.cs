using ProductLibInstance;

Product laptop = new()
{
    Name="laptop",
    Price=1500
};

Console.WriteLine($"{laptop.Name}{laptop.GetPrice()}");