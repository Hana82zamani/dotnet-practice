using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests;

public class UnitTest1
{
    [Fact]
    public void PrimeFactors_Of_4_Should_Return_2x2()
    {
        // Arrange

        // Act
        string result = PrimeFactors.GetFactors(4);

        // Assert
        Assert.Equal("2 x 2", result);
    }
    [Fact]
public void PrimeFactors_Of_7_Should_Return_7()
{

    string result = PrimeFactors.GetFactors(7);


    Assert.Equal("7", result);
}
[Fact]
public void PrimeFactors_Of_50_Should_Return_2x5x5()
{
    string result = PrimeFactors.GetFactors(50);

    Assert.Equal("2 x 5 x 5", result);
}
[Fact]
public void PrimeFactors_With_Zero_Should_Throw_Exception()
{
    Assert.Throws<ArgumentOutOfRangeException>(
        () => PrimeFactors.GetFactors(0));
}
}