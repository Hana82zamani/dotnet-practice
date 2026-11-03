using GenricLibPrint;


Product product = new()
{
    Id = 101,
    Name = "Laptop",
    Price = 1000
};

product.PrintItem(100);

product.PrintItem("Laptop");

product.PrintItem(25.5);

product.PrintItem(product);