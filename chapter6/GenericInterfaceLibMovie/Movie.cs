namespace MovieLibGenericInterface;

public interface Iprintable
{
    void Print();
}
public class Movie : Iprintable
{
    public string Title = "";
     
     public void Print()
    {
       Console.WriteLine($"Title: {Title}");
    }

}
public class Printer
{
    public static void PrintItem<T>(T Item)where T : Iprintable
    {
        Item.Print();
    }
}
