using NotificationLibIntereface;

INotification email = new EmailNotification();

email.Send();
email.ShowStatus(); // بسازی object برای استفاده از دیفالت باید این شکلی 