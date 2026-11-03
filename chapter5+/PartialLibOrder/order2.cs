namespace PartialLibOrder;

public partial class Order
{
    public decimal CalculateTax()
    {
        decimal Tax=Amount*0.09m;
        return Tax ;
    }
    public  decimal GetFinalAmount()
    {
        return Amount+CalculateTax();
    }

}

