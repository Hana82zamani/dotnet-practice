namespace ReviewLibPayment;

public class Payment
{
    public void Process(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException("invalid amount");
        }
    }

    public event EventHandler<PaymentCompletedEventArgs>? PaymentCompleted;

    public void PaymentHandler(PaymentCompletedEventArgs e)
    {
        PaymentCompleted?.Invoke(this,e);
        
    }

}
public class PaymentCompletedEventArgs : EventArgs
{
    public decimal amount;
}