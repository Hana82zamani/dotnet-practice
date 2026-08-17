namespace CommodityLibProperty;

public class Commodity
{
 private string name="";
 private decimal price;

 private int stock;

public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("enter name");
            }

            name=value;
        }

    }
    public decimal Price
    {
        get
        {
            return price;
        }
        set
        {
            if (value <0)
            {
                throw new ArgumentOutOfRangeException ("Invalid number ");
            }

            price =value;
        }

    }
    public int Stock
    {
        get
        {
            return stock;
        }
       private set
        {

            if (value <0)
            {
                throw new ArgumentOutOfRangeException ("Invalid number ");
            }
            

            stock =value;
        }
        
    }
 public void AddStock(int amount)
{
    if (amount < 0)
    {
        throw new ArgumentOutOfRangeException("amount cannot be negative.");
    }

    Stock += amount;
}

}
