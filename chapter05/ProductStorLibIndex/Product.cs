namespace ProductStorLibIndex;

public class Product
{
 
   private string _Name = "";

   private decimal _Price;

   public string Name
    {
        get
        {
            return _Name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Enter a name");
            }
            _Name=value;
        }
    }
    public decimal Price
    {
        get
        {
            return _Price;
        }
        set
        {
            if (value<0)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }
            _Price =value;
        }
    }

}

public class Store
{
    public List<Product> Products=new();

    public Product this[int index]
    {
        get
        {
            return Products[index];
        }
        set
        {
            Products[index]=value;
        }
    }
}