namespace ReviewLibNotification;

public class Notificationclass
{
public void SendEmail(string message)
{
    Console.WriteLine("send message");
}
public void SendSMS(string message)
{
     Console.WriteLine("send SMS");
}
public void ShowMessage(string message)
{
     Console.WriteLine("show message");

}
    
}

public delegate void Notification(string message);