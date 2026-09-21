namespace ApplianceBaseLibAbstract;

public abstract class ApplianceBase
{
    public string Brand="";

    public void ShowBrand()
    {
        Console.WriteLine(Brand);
    }

    public abstract void TurnOn();

} 

public class WashingMachine: ApplianceBase
{
    public override void TurnOn()
    {
        Console.WriteLine("washing machine truned on");
    }
}
