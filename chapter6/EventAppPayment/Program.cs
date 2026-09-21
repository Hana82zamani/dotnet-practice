using PaymentLibEvent;

Payment payment=new();

void ShowSuccess(object? sender,EventArgs e)
{
    Console.WriteLine("Payment successful!");

}
void UpdateAccount(object? sender,EventArgs e)
{
    Console.WriteLine("Account updated!");
}
void SendReceipt(object? sender,EventArgs e)
{
    Console.WriteLine("Receipt sent!");
}

payment.PaymentCompleted+= ShowSuccess;
payment.PaymentCompleted+=UpdateAccount;
payment.PaymentCompleted+=SendReceipt;

payment.CompletePayment();