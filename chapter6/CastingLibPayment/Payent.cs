namespace PaymentLibCasting;

public class Payment
{
    public void Pay()
    {
        Console.WriteLine("Payment is processing...");
    }

}
public class CashPayment: Payment
{
    public decimal CashAmount;
}
public class CardPayment: Payment
{
    public int CardNumber;
    public string BankName="";

    public void ShowBank()
    {
        Console.WriteLine(BankName);
    }
}