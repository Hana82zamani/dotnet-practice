namespace EventsLibProduct;
public class Product
{
    public string name{get;set;}="";

    public decimal price{get;set;}

    public event EventHandler?PriceChanged;

    public void ChangePrice(decimal newPrice)
    {

    if (price == newPrice)
    {
        return;
    }

      price=newPrice;

       PriceChanged?.Invoke(this ,EventArgs.Empty);
    }


}