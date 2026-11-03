using FieldBankAccount;

BankAccount bankAccount1 = new()
{
    Name="Hana",
    AccountNumber=16923458,
    Balance=1000
    
    
};

BankAccount bankAccount2 = new()
{
    Name="Ali",
    AccountNumber=16942458,
    Balance=2000,
    
};
Console.WriteLine($"name:{bankAccount1.Name}");
Console.WriteLine($"accont number:{bankAccount1.AccountNumber}");
Console.WriteLine($"balanc:{bankAccount1.Balance :C}");
Console.WriteLine($"interest rate :{bankAccount1.Balance*BankAccount.InterestRate :C}");
Console.WriteLine($"country:{BankAccount.Country}");
Console.WriteLine($"date:{bankAccount1.dateTime}");

Console.WriteLine($"name:{bankAccount2.Name}");
Console.WriteLine($"accont number:{bankAccount2.AccountNumber}");
Console.WriteLine($"balanc:{bankAccount2.Balance :C}");
Console.WriteLine($"interest rate :{bankAccount2.Balance*BankAccount.InterestRate:C}");
Console.WriteLine($"country:{BankAccount.Country}");
Console.WriteLine($"date:{bankAccount2.dateTime}");
