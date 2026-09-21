namespace MoneyLibOPerator;

public class Money
{
    public int Amount;

    public static Money operator +(Money money1, Money money2)
    {
        return new Money
        {
         Amount =money1.Amount+money2.Amount
        };
    }

}
//  تعریف شده money از جنس operator 