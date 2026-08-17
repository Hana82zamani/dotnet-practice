using ProductStorLibIndex;

Store store=new();

try
{
Product product1=new()
{
    Name="Laptop",
    Price=1500
};
Product product2=new()
{
    Name="phone",
    Price=500
};
Product product3=new()
{
    Name="headphone",
    Price=150
};

store.Products.Add(product1);
store.Products.Add(product2);
store.Products.Add(product3);


Console.WriteLine(store[0].Name);
Console.WriteLine(store[0].Price); 
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);

}
