namespace MessengerLibEventsMix;

public class Messenger
{
    public string name="";

    public event EventHandler<MessageEventArgs>?MessageSent;

    public void SendMessage(MessageEventArgs e)
    {
        MessageSent?.Invoke(this,e);
    }
    
}
public class MessageEventArgs : EventArgs
{
    public string Message ="";
}
