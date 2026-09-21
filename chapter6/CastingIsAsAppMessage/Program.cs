using MessageCastingIsAs;

Message[] messages =
{
    new EmailMessage
    {
        EmailAddress="@hana.com"
    },
    new SmsMessage
    {
        PhoneNumber=0912346
    }

};
foreach (Message message in messages)
{
    message.Send();

    EmailMessage? email= message as EmailMessage;  

    if(email is not null)
    {
        Console.WriteLine(email.EmailAddress);
    }

    SmsMessage? smsMessage= message as SmsMessage;

    if(smsMessage is not null)
    {
        Console.WriteLine(smsMessage.PhoneNumber);
    }
    
}