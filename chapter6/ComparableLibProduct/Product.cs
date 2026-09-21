namespace ProductLibComparable;

public class Product : IComparable<Product>
{
    public string Name = "";
    public decimal Price;

    public int CompareTo(Product? other)
    {
        if (other is null)return 1;

        return Price.CompareTo(other.Price);
    }

};
