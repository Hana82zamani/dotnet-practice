namespace NotificationLibEventDelete;

public class Notifiction
{
   public string Title="";

  public event EventHandler? NotificationSent;
public void Send()
    {
        NotificationSent?.Invoke(this,EventArgs.Empty);
    }

}
