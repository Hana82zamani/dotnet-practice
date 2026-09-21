using BankLibCasting;

Account[] accounts =
{
   new SavingsAccount
   {
       InterestRate=18.5
   },
   new BusinessAccount
   {
       CompanyName="Hana Company"
   }

};

foreach (Account account in accounts)
{
    account.ShowType();

    if (account is SavingsAccount savingsAccount)
    {
      Console.WriteLine(savingsAccount.InterestRate);
    }
    else if (account is BusinessAccount businessAccount)
    {
      Console.WriteLine(businessAccount.CompanyName);
    }
}