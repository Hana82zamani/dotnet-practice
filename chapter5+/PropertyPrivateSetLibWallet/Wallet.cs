namespace PropertyPrivateSetLibWallet;

public class Wallet
{
public string OwnerName{get; set;}="";


public decimal Balance
    {
        get; private set;
    }=100;

public void TotalBalance(decimal amount)
{
    Balance += amount;
}
      
    }



