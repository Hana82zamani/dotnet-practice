namespace PhoneLibInterface;

public interface IPrintable
{
    void Print();
}
public interface IChargeable
{
    void Charge();

}

public class Phone : IPrintable , IChargeable
{

    public string Model="";
    public void Print()
    {
        Console.WriteLine($"{Model}");
    }
    public void Charge()
    {
        Console.WriteLine($"{Model}");
    }

}
