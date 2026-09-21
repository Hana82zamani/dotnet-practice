using PaymentLibCasting;

Payment[] payments =
{
    new CashPayment
    {
        CashAmount=1500  
    },
    new CardPayment
    {
        CardNumber=1534578,
        BankName="Melat"
        
    }
};
foreach (Payment payment in payments)
{
    payment.Pay();

    if(payment is CashPayment cashPayment)
    {
        Console.WriteLine(cashPayment.CashAmount);
    }
    else if (payment is CardPayment cardPayment)
    {
        Console.WriteLine(cardPayment.BankName);
        Console.WriteLine(cardPayment.CardNumber);
    }

    
}