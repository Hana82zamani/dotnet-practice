using ProductLibComparable;
Product[]products=
{
    new Product
    {
        Name="Laptop",
        Price=1200
    },
    new Product
    {
        Name= "Mouse",
        Price=20
        
    },
    new Product
    {
        Name="Keyboard",
        Price=50
    }
};
Array.Sort(products);

foreach (Product product in products)
{
    Console.WriteLine(product.Name);
}
    

  