using ProductLibStatic;

Product laptop = new()
{
    Name="Laptop",
    Price=1500

};

Console.WriteLine($"{laptop.Name}:{Product.GetPrice(laptop)}");