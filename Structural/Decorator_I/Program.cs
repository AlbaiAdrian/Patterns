// See https://aka.ms/new-console-template for more information
using Decorator_I;

Console.WriteLine("Hello, World!");

MailNotification mailNotification = new MailNotification();
mailNotification.SendNotification();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

SMSNorificationDecorator smsNorificationDecorator = new SMSNorificationDecorator(mailNotification);
smsNorificationDecorator.SendNotification();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

FacebookNotificationDecorator facebookNotificationDecorator = new FacebookNotificationDecorator(smsNorificationDecorator);
facebookNotificationDecorator.SendNotification();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

FacebookNotificationDecorator facebookNotificationDecorator1 = new FacebookNotificationDecorator(null);
SMSNorificationDecorator smsNorificationDecorator1 = new SMSNorificationDecorator(facebookNotificationDecorator1);
smsNorificationDecorator1.SendNotification();


Console.ReadLine();