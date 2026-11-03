namespace TupleLibSales;

public class SalesReport
{

  
    public static (string Name,int number,decimal income,decimal average)
    SaleFactor(string name,decimal Price,int NumberSale)
    {

        if (NumberSale<= 0)
        {
            throw new ArgumentException("Number of sales must be greater than zero.");
        }
        decimal income=Price*NumberSale;
        decimal average=income/NumberSale;


        return (name,NumberSale,income,average);
    }

}
