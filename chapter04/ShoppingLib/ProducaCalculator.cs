namespace ShoppingLib;

public static class ProductCalculator
{
    public static decimal CalculateTotal(decimal price, int quantity)
    {
        return price * quantity;
    }
}