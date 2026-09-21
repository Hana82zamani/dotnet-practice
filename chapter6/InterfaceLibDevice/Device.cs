namespace DeviceLibInterface;
public interface IScannable
{
    void Scan();
    
}
public interface IConnectable
{
    void Connect();
}

public class Printer: IScannable,IConnectable
{
    public string name ="";
    
    public void Scan()
    {
        Console.WriteLine($"{name}");
    }
    public void Connect()
    {
        Console.WriteLine($"{name}");
    }

}
