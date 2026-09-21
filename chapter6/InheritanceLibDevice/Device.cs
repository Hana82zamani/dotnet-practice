namespace DeviceLibInheritance;

public class Device
{

    public void Start()
    {
        Console.WriteLine("Device is starting...");
    }


}
public class Laptop : Device
{
    public new void Start()
    {
        Console.WriteLine("Laptop is starting...");
    }
}
