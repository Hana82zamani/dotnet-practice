using calculatorLibReview;

namespace calculatorLibReviewTest;

public class UnitTest1
{
    [Fact]
    public void calculatorLibReviewTest1()
    {
     //Arrange
    
     int x=10;
     int y=5;
     int expect=15;

     //Act
    int actual=  CalculatorReview .Add(x,y);

     //Assert
     Assert.Equal(expect,actual);
    }
}

/// dotnet new classlib -n calculatorLibReview = ساختن فایل اصلی پروژه تست 
/// dotnet new xunit -n CalculatorLibReviewTest = ساختن فایل تست (همین فایل )
/// dotnet add Test reference file = بهم وصل کردن دو فایل 
/// dotnet test = اجرای تست
///  میشن نباید نیو کلس ساختreturn برای تابع هایی که 