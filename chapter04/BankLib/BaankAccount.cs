namespace BankLib;

public class BankAccount
{
    public static decimal Withdraw(decimal balance, decimal amount)
    {
        if (amount > balance)
        {
            throw new InvalidOperationException("Not enough balance.");
        }

        return balance - amount;
    }
}