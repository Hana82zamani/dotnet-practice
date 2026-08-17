namespace ProductLib;

public class Product
{
    public string Name;
    public decimal Price;

    public Product()
    {
        Name="unknown";
        Price= 0;
    }

    public Product(string name , decimal price)
    {
        Name=name;
        Price=price;

    }
}