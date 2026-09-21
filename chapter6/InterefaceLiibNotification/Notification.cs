namespace NotificationLibIntereface;

public interface INotification
{
    void Send();

    void ShowStatus()
{
    Console.WriteLine("Notification system is ready");
}
}
public class EmailNotification:INotification
{
    public void Send()
    {
        Console.WriteLine("Email notification sent");
    }
    

}
