using GenricRepositoryLibShopping;

Repository<Product> products = new();

products.Add(new Product
{
    Name="Laptop",
    Id=101,
    Price=1500
}
);
products.GetAll();

foreach (Product product in products.GetAll())
{
    Console.WriteLine($"{product.Name}={product.Price}");

}

Repository<Customer>customers = new();

customers.Add(new Customer
{
    Name="Hana",
    Id=369
});
customers.GetAll();

foreach (Customer customer in customers.GetAll())
{
     Console.WriteLine($"id:{customer.Id}={customer.Name}");   
}
