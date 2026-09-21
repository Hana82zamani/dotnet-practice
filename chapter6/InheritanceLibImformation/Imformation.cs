namespace ImformationLibInheritance;

public class DeviceInfo
{
    public void ShowInfo()
    {
        Console.WriteLine("General device information");
    }

}
public class GamingDevice : DeviceInfo
{
    public new void ShowInfo()
    {
        Console.WriteLine("Gaming device information");
    }
}
