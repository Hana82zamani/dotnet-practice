namespace StartLibInterface;

public interface Istartable
{
    void Start();
}
public class Car :Istartable
{
    public string Model = "";

    public void Start()
    {
        Console.WriteLine($"car {Model} started");
    }

}
public class Robot: Istartable
{
    public string Name = "";

    public void Start()
    {
        Console.WriteLine($"robot {Name} started");
    }
}
