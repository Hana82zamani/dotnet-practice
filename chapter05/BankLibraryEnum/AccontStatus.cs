namespace BankLibraryEnum;

public enum AccountStatus
{
    Active,
    Blocked,
    Closed
}

public class Account
{
    public string Owner = "";
    public decimal Balance;
    public AccountStatus Status;
}