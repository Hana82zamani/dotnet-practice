namespace ElDeviceLibInterface;

public class Device
{
   public void TurnOn()
    {
        Console.WriteLine("device Turned on");
    }

}
 public interface IConnectable
{
     void Connect();
}

public class Laptop: Device , IConnectable
{
    public void Connect()
    {
        Console.WriteLine("laptop connected");
    }
}