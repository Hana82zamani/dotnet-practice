namespace OrderLibEvent;

public class Order
{
    public event EventHandler? OrderPlaced;

    public void PlaceOrder()
    {
        OrderPlaced?.Invoke(this,EventArgs.Empty);
    }

}
