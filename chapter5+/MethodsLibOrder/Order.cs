namespace MethodsLibOrder;

public class Order
{
   public string CustomerName="";
   public string ProductName="";
   public decimal Price;
   public int Quantity;

   public double Discount;

    public decimal TotalPrice(decimal discount=0)
    {
        return (Price*Quantity)-(Price*discount);
    }

}
