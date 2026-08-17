using CommodityLibProperty;

Commodity commodity=new();

try
{
    commodity.Name="Laptop";
    commodity.Price=1000;
    commodity.AddStock(10);
    
    Console.WriteLine(commodity.Name);
    Console.WriteLine(commodity.Price);
    Console.WriteLine(commodity.Stock);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}