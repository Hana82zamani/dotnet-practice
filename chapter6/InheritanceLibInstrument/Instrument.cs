namespace InstrumentLibInheritance;

public class Instrument
{
   public void Play()
{
    Console.WriteLine("Playing instrument...");
}

}
public class Piano : Instrument
{
    public new void Play()
    {
        Console.WriteLine("Playing piano...");
    }
}