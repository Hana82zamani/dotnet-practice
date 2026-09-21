namespace PaymentLibSealed;

public sealed class Payment
{
    public void Pay()
    {
        Console.WriteLine("Payment completed");
    }

}
public class CreditCard : Payment // sealed خطا عمدی 
{
}
