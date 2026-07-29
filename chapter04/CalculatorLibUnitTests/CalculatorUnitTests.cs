using CalculatorLib;

namespace CalculatorLibUnitTests;

public class CalculatorUnitTests
{
    [Fact]
    public void TestMultiply5And4()
    {
        // Arrange
        Calculator calc = new();

        int a = 5;
        int b = 4;

        int expected = 20;


        // Act
        int actual = calc.Multiply(a, b);


        // Assert
        Assert.Equal(expected, actual);
    }
}