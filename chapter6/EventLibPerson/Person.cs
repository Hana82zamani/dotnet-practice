namespace PersonLibEvent;

public class Person
{
    public  event  EventHandler? shout;

    public void Poke()
    {
        shout?.Invoke(this,EventArgs.Empty);
    }

}
