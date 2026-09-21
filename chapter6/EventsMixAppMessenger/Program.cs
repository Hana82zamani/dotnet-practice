using MessengerLibEventsMix;

Messenger messenger1 = new()
{
    name="Hana"
};

Messenger messenger2 = new()
{
    name="Ali"
};

MessageEventArgs messageEventArgs1 = new()
{
    Message="Hello!"
};

MessageEventArgs messageEventArgs2 = new()
{
    Message="How are you?"
};

void Messenger_MessageSent(object? sender,MessageEventArgs e)
{
    if(sender is not Messenger messenger)return;
    Console.WriteLine($"{messenger.name} send: {e.Message}");
    

}
messenger1.MessageSent+=Messenger_MessageSent;
messenger2.MessageSent+=Messenger_MessageSent;

messenger1.SendMessage(messageEventArgs1);
messenger2.SendMessage(messageEventArgs2);
