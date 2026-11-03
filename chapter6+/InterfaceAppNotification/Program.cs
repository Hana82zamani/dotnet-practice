using InterfaceLibNotification;


INotification notification = new SmsNotification();

notification.Send("Your order has been confirmed");

INotification notification2 = new EmailNotification();

notification2.Send("Your order has been confirmed");