namespace OperatorOverloadingStaticLibPayment;
public class Payment
{
    public decimal Amount{get;set;}

public static bool IsGreater(Payment p1 ,Payment p2)
    {
        return p1.Amount>p2.Amount;
    }

public static bool operator >(Payment p1, Payment p2)
    {
        return p1.Amount>p2.Amount;
    }
  
public static bool operator <(Payment p1, Payment p2)
    {
        return p1.Amount<p2.Amount;
    }

}
