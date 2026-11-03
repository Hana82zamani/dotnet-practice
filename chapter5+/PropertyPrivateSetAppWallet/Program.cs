using PropertyPrivateSetLibWallet;

Wallet wallet = new()
{
    OwnerName="Hana",

};

wallet.TotalBalance(500);

Console.WriteLine(wallet.Balance);

