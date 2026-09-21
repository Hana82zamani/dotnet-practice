using DoorLibEventSender;

Door door = new()
{
    Name="Front door"
};



 void Door_Opened(object? sender,EventArgs e)
{
    if (sender is not Door d) return;

    Console.WriteLine($"{d.Name} was opened!");
}

door.OpenedEvent+=Door_Opened;

door.Open();