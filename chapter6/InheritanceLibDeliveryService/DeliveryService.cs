namespace DeliveryServiceLibInheritance;

public abstract class DeliveryService
{
    public abstract void Deliver();

}
public class NormalDelivery: DeliveryService
{
    public override void Deliver()
    {

        Console.WriteLine(" normal order ");
    }
}
public class FastDelivery : DeliveryService
{
    public override void Deliver()
    {

        Console.WriteLine(" fast order");
    }
}

public class InternationalDelivery : FastDelivery
{
    public sealed override void Deliver()
    {
        Console.WriteLine(" international order ");
    }
}
