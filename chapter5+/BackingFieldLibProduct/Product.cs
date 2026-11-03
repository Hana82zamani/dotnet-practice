namespace BackingFieldLibProduct;

public class Product
{
    public string name{get; set;}="";

    private decimal _Price;

    public decimal price
    {
        get
        {
            return _Price;
        }
        set
        {
            if (value > 0)
            {
                _Price=value;
            }
        }
    }

}
