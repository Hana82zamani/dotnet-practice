namespace CarLibStaticInstance;

public class Car
{
   public string Brand="";
   public double Price;

   public static double GetPrice(Car car)
    {
        return car.Price;
    }
    public double GetPrice()
    {
        return GetPrice(this);
    }
    

}
