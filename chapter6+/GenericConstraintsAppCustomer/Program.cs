using GenericConstraintsLibCustomer;

Customer customer1 = new()
{
    Name="Hana"
};

StoreRepository<Customer>customer=new(customer1);

Product product1 = new()
{
    Name="Laptop",
    Price=2500
};
StoreRepository<Product>product=new(product1);

Console.WriteLine(customer.Item.Name);
Console.WriteLine($"{product.Item.Name}={product.Item.Price}");
