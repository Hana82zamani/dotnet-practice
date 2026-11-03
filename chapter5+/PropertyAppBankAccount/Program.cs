using PropertyLibBankAccount;

Account account = new()
{
    OwnerName="Hana",
    AccountNumber=10025,
    Balance=15000
};
Console.WriteLine(account.OwnerName);
Console.WriteLine(account.AccountNumber);
Console.WriteLine(account.Balance);

account.Balance=20000;
Console.WriteLine(account.Balance);