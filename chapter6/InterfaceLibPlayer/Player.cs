namespace PlayerLibInterface;

public interface IPlayable
{
   void Play();
}

public interface IPrintable
{
    void Print();
}

public class Book : IPrintable
{
    public string Title = "";

   public void Print()
    {
     Console.WriteLine($"Book :{Title}");   
    }

}
public class Movie: IPrintable
{
    public string Title = "";

    public void Print()
    {
        Console.WriteLine($"Movie :{Title}");
    }
}
public class Song :IPlayable
{
    public string Title="";

    public void Play()
    {
        Console.WriteLine($"{Title} is played");
    }

}


