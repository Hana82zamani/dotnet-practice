namespace ApplianceLibInheritance;

public class Appliance
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Appliance is turning on...");
    }
}

public class Television: Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Television is turning on...");
    }
}