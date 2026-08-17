namespace BankLibProperty;

public class Bank
{
 private decimal balance;

 public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
         if ( value<0)
            {
                throw new ArgumentException("blance shouln't be negative");
            }


           balance= value;

        }
    }

        
    
}
