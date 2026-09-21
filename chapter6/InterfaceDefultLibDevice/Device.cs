namespace DeviceLibInterfaceDefult;

public interface IDevice
{
    void Start();

    void Pause()
    {
        Console.WriteLine("Default Pause");
    }

    void Stop()
    {
        Console.WriteLine("Default Stop");
    }
}
public class Laptop: IDevice
{
   public void Start()
    {
        Console.WriteLine("Laptop is started");
    }

    public void Stop()
    {
         Console.WriteLine("Laptop is stopped");
        
    }


}
