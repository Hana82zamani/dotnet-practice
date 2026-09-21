using MoneyLibStaticOperator;

Money money1 = new()
{
    Amount=1000
};
Money money2 = new()
{
    Amount=1500
};

Money result = Money.Add(money1,money2);

Money result2= money1+money2;