using DiscountLib;

namespace DiscountLibUnitTests;

public class DiscountLibUnitTests
{
    [Fact]
    public void DiscountCalculatorTest()
    {

    // Arrange
    DiscountCalculator calc = new();
    double price = 100;
    double discountPercent = 20;
    double expected=80;

        // Act
    double actual = Calc.CalculateDiscount(price,discountPercent);


        // Assert
    Assert.Equal(expected,actual);
    
    }
}