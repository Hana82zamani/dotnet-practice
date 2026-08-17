using BankLibraryEnum;

Account bank = new()
{
Owner= "Hana",
Balance= 5000,
Status=AccountStatus.Active
};
Console.WriteLine($"owner:{bank.Owner}");

Console.WriteLine($"balance:{bank.Balance}");

Console.WriteLine($"status:{bank.Status}");

Console.WriteLine($"Number: {(int)bank.Status}");

if (bank.Status == AccountStatus.Active)
{
    Console.WriteLine("Account is available");
}
if (bank.Status == AccountStatus.Blocked)
{
    Console.WriteLine("Account is blocked ");
}
if (bank.Status == AccountStatus.Closed)
{
    Console.WriteLine("Account has closed");
}
