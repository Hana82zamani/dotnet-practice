namespace PaymentLibEvent;

public class Payment
{
    public event EventHandler? PaymentCompleted;

    public void CompletePayment()
    {
        PaymentCompleted?.Invoke(this,EventArgs.Empty);
    }
}
