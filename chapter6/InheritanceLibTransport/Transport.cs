namespace TransportLibInheritance;

public class Transport
{
    public virtual void Move()
    {
        Console.WriteLine(" transport moved");
    }

}
public class Train : Transport
{
    public override void Move()
    {
        Console.WriteLine("Train is moving on rails");
    }
}
public class Boat : Transport
{
    public override void Move()
    {
        Console.WriteLine("Boat is moving on water");
    }
}
