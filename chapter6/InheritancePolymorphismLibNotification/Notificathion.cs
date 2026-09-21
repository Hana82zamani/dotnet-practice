namespace NotificationLibInheritancePolymorphism;

public class Notification
{
    public virtual void Send()
    {
        Console.WriteLine("Sending notification");
    }
}

public class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending email");
    }
}
