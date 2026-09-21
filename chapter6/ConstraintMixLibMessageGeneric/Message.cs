namespace MessageGenericLibConstraintMix;

public class Message
{
    public string Text = "";
}
public class EmailMessage : Message
{
}

public class MessageFactory 
{
    public static T Create<T>()where T : Message,new()
    {
        return new T ();
    }
}
