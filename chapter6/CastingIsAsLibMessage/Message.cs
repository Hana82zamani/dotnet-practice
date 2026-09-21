namespace MessageCastingIsAs;

public class Message
{
    public void Send()
    {
        Console.WriteLine("Sending message...");
    }
}
public class EmailMessage : Message
{
    public string EmailAddress="";

    public void ShowEmail()
    {
        Console.WriteLine(EmailAddress);
    }
}
public class SmsMessage : Message
{
    public int PhoneNumber;
    public void ShowPhone()
    {
        Console.WriteLine(PhoneNumber);
    }
}