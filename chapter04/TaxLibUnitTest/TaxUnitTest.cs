using taxlib;

namespace TaxLibUnitTest;

public class TaxLibUnitTest
{
    [Fact]
    public void TaxUnitTest250()
    {

//Arrange
TaxCalculator calc=new();
double price = 250;
double expected= 22.5;

//Act
double actual= calc.CalculateTax(price);


//Assert
Assert.Equal(expected,actual);

    }

    [Fact]
    public void TaxUnitTest100()
    {
        // Arrange
        TaxCalculator calc = new();

        double price = 100;
        double expected = 9;

        // Act
        double actual = calc.CalculateTax(price);

        // Assert
        Assert.Equal(expected, actual);
    }

}
/// dotnet new classlib -n taxlib = ساختن فایل اصلی پروژه تست 
/// dotnet new xunit -n TaxLibUnitTest = ساختن فایل تست (همین فایل )
/// dotnet add TaxLibUnitTest reference = بهم وصل کردن دو فایل 
/// dotnet test = اجرای تست