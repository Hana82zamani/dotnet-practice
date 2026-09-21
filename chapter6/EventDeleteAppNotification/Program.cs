using NotificationLibEventDelete;

Notifiction notifiction = new()
{
    Title = "New Message"
};

void ShowNotification (object?sender,EventArgs e)
{
    Console.WriteLine("Notification shown!");
};
void SaveNotification(object?sender,EventArgs e)
{
    Console.WriteLine("Notification saved!");
}

notifiction.NotificationSent+=ShowNotification;
notifiction.NotificationSent+=SaveNotification;

notifiction.Send();

notifiction.NotificationSent-=SaveNotification;


notifiction.Send();
