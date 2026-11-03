namespace RefInOutLibPayment;

public class Payment
{
    public void plus(ref decimal amount)
    {
        amount=amount+(amount*0.10m);
      ;
    }
    
    public void Tax(decimal amount ,out decimal TaxAmount, out decimal TotalAmount)
    {
        TaxAmount=amount*0.09m;
        TotalAmount=amount+TaxAmount;
    }
    public void Show(in decimal amount)
    {
        Console.WriteLine($"amount: {amount}");
    }

}
