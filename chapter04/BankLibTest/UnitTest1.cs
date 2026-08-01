using BankLib;

namespace BankLibTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
    // Arange 
    decimal amount=200;
    decimal balance=100;
    decimal expect;

    // Act
    decimal actual= BankAccount.Withdraw(100,200);
   
    // Act & Assert
        Assert.Throws<InvalidOperationException>(() =>
        {
            BankAccount.Withdraw(balance, amount);
        });
}

}
// را جدا بنویسیمact assert  میگیریم نباید exception xunitزمانی که در 