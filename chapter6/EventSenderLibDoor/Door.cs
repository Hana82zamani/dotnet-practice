namespace DoorLibEventSender;

public class Door
{
   public string Name="";

   public event EventHandler? OpenedEvent;

   public void Open()
    {
        OpenedEvent?.Invoke(this,EventArgs.Empty);
    }


}
