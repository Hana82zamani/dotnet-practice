namespace LocalFunctionLibShop;

public class Shop
{
    public static decimal OnlineShop(decimal price,int Quantity)
    {
        
         decimal Discount(decimal Total)
        {
            if (Total > 5000000)
            {
              
                return Total*0.10m;
            }

          return 0;

        }

         decimal Total=price*Quantity;
            
            return Total-Discount(Total); 


    }

}
