namespace PrintLibExplicit;

public interface IPrinter
{
    void Start();
}
public interface IScanner
{
    void Start();
}

public class Device : IPrinter, IScanner
{
    void IPrinter.Start()
    {
        Console.WriteLine("printer started");
    }

    void IScanner.Start()
    {
        Console.WriteLine("scanner started");
    }


}
