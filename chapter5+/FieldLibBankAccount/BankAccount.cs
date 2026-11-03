namespace FieldBankAccount;

public class BankAccount
{
public string Name="";
public int AccountNumber;

public decimal Balance=0;

public static decimal InterestRate=0.02m;

public const string Country="Iran";

public readonly DateTime dateTime;

public BankAccount()
{
     dateTime=DateTime.Now;   
}
}

