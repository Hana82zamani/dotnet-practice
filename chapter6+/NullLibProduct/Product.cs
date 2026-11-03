namespace NullLibProduct;

public class Product
{
    public string Name { get; set; } = "";
    public string? Description { get; set; }

    public void ShowDescription(Product product)
    {
        string result=product.Description??"no description";
        Console.WriteLine(product.Name);
        Console.WriteLine(result); 
    }
}
