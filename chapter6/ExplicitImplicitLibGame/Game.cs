namespace GameLibExplicitImplicit;

public interface IOnline
{
    void Connect();
}

public interface IOffline
{
    void Connect();
}

public class Game:IOnline,IOffline
{
    void IOnline.Connect()
    {
        Console.WriteLine("Connected to online server");
    }
    void IOffline.Connect()
    {
        Console.WriteLine("Playing offline");
    }

}
