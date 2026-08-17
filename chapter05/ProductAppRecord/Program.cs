using ProductLibRecord;

Product product = new()
{
    Name = "Laptop",
    Price = 1000
};
Product newProduct = product with
{
    Price= 1200

};

Console.WriteLine(product.Name);
Console.WriteLine(newProduct.Price);