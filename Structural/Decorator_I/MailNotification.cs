namespace Decorator_I;

internal class MailNotification : INotification
{
    public void SendNotification()
    {
        Console.WriteLine("Mail notificatin sent!");
    }
}
