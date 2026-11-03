namespace ExplicitInterfaceLibPrint;

public interface IPrinter
{
    void Start();
}

public interface IScanner
{
    void Start();
}
public class MultiFunctionDevice : IPrinter, IScanner
{
    public void Start()
    {
        Console.WriteLine("start print");
    }
    void IScanner.Start()

    {
        Console.WriteLine("start scanner");
    }
}

