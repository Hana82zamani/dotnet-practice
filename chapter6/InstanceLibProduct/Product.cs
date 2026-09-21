namespace ProductLibInstance;

public class Product
{
    public string Name = "";
    public double Price;

    public static double GetPrice(Product product)
    {
        return product.Price;
    }

    public double GetPrice()
    {
        return GetPrice(this);
    }
}