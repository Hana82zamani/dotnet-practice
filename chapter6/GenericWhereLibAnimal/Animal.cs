namespace AnimalLibGenericWhere;

public class Animal
{
   public string Name="";
   public int Age;

}
public class AnimalHelper
{
    public static T Create<T>()where T : Animal, new()
    {
        return new T ();
    }
}