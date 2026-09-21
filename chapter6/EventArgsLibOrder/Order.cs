namespace OrderLibEventArgs;

public class Order
{
  public int OrderId;
  public event EventHandler<OrdersEventArgs>? OrderCompleted;

 public void Complete(OrdersEventArgs e)
    {
        OrderCompleted?.Invoke(this,e);
        
    }

}

public class OrdersEventArgs : EventArgs
{
    public decimal TotalPrice;
}
