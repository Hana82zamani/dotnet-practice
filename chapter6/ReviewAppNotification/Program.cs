using ReviewLibNotification;

Notificationclass notificationclass =new();

Notification d=notificationclass.SendEmail;

d+=notificationclass.SendSMS;

d+=notificationclass.ShowMessage;

d-=notificationclass.SendSMS;

d("hi");