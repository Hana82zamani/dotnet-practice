namespace SmartDeviceLibAbstract;

public abstract class SmartDevice
{
   public string Name="";

   public void ShowName()
    {
        Console.WriteLine(Name);
    }
    public abstract void Connect();

}
public interface IRechargeable
{
    void Recharge();
}

public class SmartWatch : SmartDevice , IRechargeable
{
    public override void Connect()
    {
        Console.WriteLine("smartwatch connected");
    }

    public void Recharge()
    {
          Console.WriteLine("Smartwatch is recharging");
    }
}