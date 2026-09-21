namespace ProductLibComparer;

public class Product
{
    public string Name = "";
    public decimal Price;
}
 public class ProductComparer: IComparer<Product>
{
    public int Compare(Product? X, Product? y)
    {
        if (X is null) return -1;
        if (y is null) return 1;
        
        int result= X.Price.CompareTo(y.Price);

        if (result==0)
        {
            return X.Name.CompareTo(y.Name);
        }

        return result;
    }


}