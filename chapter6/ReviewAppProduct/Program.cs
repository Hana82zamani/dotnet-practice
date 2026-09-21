using ReviewLibProduct;

    static void Print<T>(T item)
    {
        Console.WriteLine(item);
    }
    
Print(100);
Print("Hello");


Product[] products =
{
    new Product
    {
        Name="Laptop" ,
        Price= 500
        
    },
    new Product
    {
        Name="Mouse" ,
        Price= 50
        
    },
    new Product
    {
        Name="Keyboard" ,
        Price= 100
        
    }

};
foreach (Product product in products)
{
    Console.WriteLine($"{product.Name}={product.Price}");
   
}
ProductStorage storage = new();

storage.Add(products[0]);
storage.Add(products[1]);
storage.Add(products[2]);

storage.ShowAll();
Customer customer1 = new()
{
    Name = "Ali",
    Age = 22
};
CustomerStorage customerStorage = new();

customerStorage.Add(customer1);
customerStorage.ShowAll();

