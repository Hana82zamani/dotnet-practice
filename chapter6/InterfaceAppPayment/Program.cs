using PaymentLibInterface;
Payment payment=new();

IRefundable refundable=new CreditCardPayment();

payment.Process();

refundable.ShowMessage();

refundable.Refund();



