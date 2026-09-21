namespace ProductLibGenericWhere;

public class Product
{
 public string  Name="";
public decimal Price;

}

public class ProductHelper
{
    public static void show<T>(T product) where T : Product
    {
        Console.WriteLine($"Name: {product.Name}");
       Console.WriteLine($"Price: {product.Price}");
}
    }
