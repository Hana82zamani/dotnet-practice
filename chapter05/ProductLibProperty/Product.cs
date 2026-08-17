namespace ProductLibProperty;

public class Product 
{
    private decimal price;
    
    public decimal Price
    {
        get
        {
            return price;
        }
        set
        {

            if (value < 0)
            {
             throw new ArgumentOutOfRangeException("Invalid price");   
            }

            price=value;
        }

    }

    public decimal DiscountedPrice
    {
        get
        {
            return price*0.9m;
        }
    }

}
