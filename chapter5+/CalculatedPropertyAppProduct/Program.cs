using CalculatedPropertyLibProduct;

Product product = new()
{
Name = "Keyboard",
Price = 800000,
Quantity = 3
};
Console.WriteLine(product.Name);
Console.WriteLine(product.Price);
Console.WriteLine(product.Quantity);
Console.WriteLine(product.TotalPrice);
Console.WriteLine("----------");
product.Quantity=5;
Console.WriteLine(product.Quantity);
Console.WriteLine(product.TotalPrice);