using BankLibProperty;

Bank account = new();

account.Balance = 1000;
try
{
  Console.WriteLine(account.Balance);  
}
catch
{
    throw new ArgumentException("Invalid balance");
}


account.Balance = -1500;
try
{
  Console.WriteLine(account.Balance);  
}
catch
{
    throw new ArgumentException("Invalid balance");
}


