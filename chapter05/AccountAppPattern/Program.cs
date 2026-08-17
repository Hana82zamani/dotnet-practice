using AccountLibPattern;

Account[] accounts =
{
    new FreeAccount
    {
        Username="hana",
        DaysActive=10
    },
    new PremiumAccount
    {
        Username="Ali",
        DaysActive=100,
        Downloads=150
    },
    new PremiumAccount
    {
        Username="Sara",
        DaysActive=30,
        Downloads=20
    },
    new BusinessAccount
    {
        Username="Mina",
        Employee=20,
        StorageGB=500
    },
    new BusinessAccount
    {
        Username="Reza",
        Employee=3,
        StorageGB=100
    }
};
foreach (Account account in accounts)
{
    string status= account switch
    {
        FreeAccount{DaysActive:<30}=> "New Free User",
        FreeAccount{DaysActive:>=30}=> "Regular Free User",
        PremiumAccount {DaysActive:>=90, Downloads:>=100}=>"Premium Power User",
        PremiumAccount =>"Regular Premium User",
        BusinessAccount{Employee:>=10, StorageGB:>=300}=>"Large Business",
        BusinessAccount => "Small Business",
        _ => "unKnown"
    };
     Console.WriteLine($"{account.Username}:{status}");
  
}