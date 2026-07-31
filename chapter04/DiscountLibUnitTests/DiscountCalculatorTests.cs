using DiscountLib;

namespace DiscountLibUnitTests;

public class DiscountLibUnitTests
{
    [Fact]
    public void DiscountCalculatorTest()
    {

    // Arrange
    DiscountCalculator Calc = new();
    double price = 100;
    double discountPercent = 20;
    double expectd=80;

        // Act
    double actual = Calc.CalculateDiscount(price,discountPercent);


        // Assert
    Assert.Equal(expectd,actual);
    
    }
}