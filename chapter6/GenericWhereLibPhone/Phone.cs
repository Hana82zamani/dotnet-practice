namespace PhoneLibGenericWhere;

public class Phone
{
  public string Brand="";
  public double Price;

}
public class Factory
{
    public static T Creat<T>() where T : new()
    {
       return new T ();
    }
}
