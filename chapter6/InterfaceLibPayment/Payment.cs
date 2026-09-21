namespace PaymentLibInterface;

public class Payment
{
 public void Process()
    {
        Console.WriteLine("Payment is being processed");
    }
}
public interface IRefundable
{
void Refund();

void ShowMessage()
{
    Console.WriteLine("Refund system is available");
}
}
public class CreditCardPayment:Payment, IRefundable
{
   public void Refund()
    {
        Console.WriteLine("Credit card payment refunded");
    }
}

