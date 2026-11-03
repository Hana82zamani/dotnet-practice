namespace InterfaceLibNotification;

public interface INotification
{
   public void Send(string message);
}

public class SmsNotification: INotification
{
   public void Send(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}

public class EmailNotification:INotification
{
   public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}