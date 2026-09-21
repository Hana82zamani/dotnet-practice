namespace BankLibCasting;

public class Account
{
  public void ShowType()
    {
        Console.WriteLine("This is an account");
    }
} 
public class SavingsAccount : Account
{
    public double InterestRate;

}
public class BusinessAccount : Account
{

    public string CompanyName="";

}
