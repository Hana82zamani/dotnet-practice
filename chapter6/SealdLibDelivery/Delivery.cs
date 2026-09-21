namespace DeliveryLibSeald;

public class Delivery
{
    public virtual void Deliver()
    {
        Console.WriteLine("order delivered");
        
    }

}
public class ExpressDelivery: Delivery
{
    public sealed override void Deliver()
    {
        Console.WriteLine("Express order delivered");
    }
}
public class InternationalDelivery: ExpressDelivery
{
    public override void Deliver()// در متدقبلی استفاده شده sealed  خطای عمدی چون 
    {
      Console.WriteLine("International order delivered");  
    }
}
