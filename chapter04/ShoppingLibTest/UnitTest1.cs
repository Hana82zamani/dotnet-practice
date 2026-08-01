using ShoppingLib;

namespace ShoppingTests;

public class ProductCalculatorTests
{
    [Theory]
    [InlineData(100, 2, 200)]
    [InlineData(50, 5, 250)]
    [InlineData(10, 10, 100)]
    public void CalculateTotal_ShouldReturnCorrectPrice(
        decimal price,
        int quantity,
        decimal expected)
    {
        // Arrange
        

        // Act
        decimal actual = ProductCalculator.CalculateTotal(price, quantity);

        // Assert
        Assert.Equal(expected, actual);
    }
}