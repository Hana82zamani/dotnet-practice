
namespace DiscountLib;

public class DiscountCalculator
{
    public double CalculateDiscount(double price, double discountPercent)
    {
        return price - (price * discountPercent / 100);
    }
}