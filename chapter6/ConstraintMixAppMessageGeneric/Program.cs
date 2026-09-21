using MessageGenericLibConstraintMix;

EmailMessage email = MessageFactory.Create<EmailMessage>();

email.Text = "Hello Hana";

Console.WriteLine(email.Text);