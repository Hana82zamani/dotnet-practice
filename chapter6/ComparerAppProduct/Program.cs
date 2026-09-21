using ProductLibComparer;

Product[] products =
{
    new Product
    {
        Name="Laptop",
        Price=1200
    },
    new Product
    {
        Name="Mouse",
        Price=50
    },
    new Product
    {
        Name="Keyboard",
        Price=50
    },
};
Array.Sort(products, new ProductComparer());

foreach (Product product in products)
{
    Console.WriteLine(product.Name);
}