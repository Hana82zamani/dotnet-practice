using MethodsLibOrder;

Order order1 = new()
{
    CustomerName="Hana",
    ProductName="Laptop",
    Price = 1000,
    Quantity=1,

};

Order order2 = new()
{
    CustomerName="Ali",
    ProductName="Phone",
    Quantity=2,
    Price = 1500,

};
Console.WriteLine($"customer:{order1.CustomerName},product:{order1.ProductName},");

Console.Write($"Quantity:{order1.Quantity},");

Console.WriteLine($" price ={order1.TotalPrice(0.1m)}");

Console.WriteLine($"customer:{order2.CustomerName},product:{order2.ProductName},");

Console.Write($"Quantity:{order2.Quantity},");

Console.Write($" price ={order2.TotalPrice()}");