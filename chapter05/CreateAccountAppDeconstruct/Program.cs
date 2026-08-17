using CreateAccountLibDeconstruct;

Account account=new();

Console.WriteLine(account.CreateAccount("Hana", 22));

Console.WriteLine(account.CreateAccount("Ali", 25, "Germany"));

Console.WriteLine(account.CreateAccount(username:"Sara",age: 20,active: false,country: "Turkey"));