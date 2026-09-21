using MoneyLibOPerator;

Money money1 = new()
{
    Amount=1000
};
Money money2 = new()
{
    Amount=3000
};

Money result= money1+money2; // تعریف میشهmoney هم result است money از جنس operator چون 

Console.WriteLine(result.Amount);
