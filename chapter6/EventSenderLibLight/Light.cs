namespace LightLibEventSender;

public class Light
{
    public string Name="";

    public event EventHandler ? TurnedOn;

    public void TurnOn()
    {
        TurnedOn?.Invoke(this,EventArgs.Empty);
    }


}
