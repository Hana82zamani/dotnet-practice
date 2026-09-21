namespace FoodOrderLibEventMix;

public class FoodOrder
{
   public string  RestaurantName ="";

   public event EventHandler<OrderEventArgs>? OrderReady;
   public void PrepareOrder(OrderEventArgs e)
    {
        OrderReady?.Invoke(this, e);
    }

}
public class OrderEventArgs : EventArgs
{
  public  int  OrderNumber ;
   public  string FoodName="";
}

