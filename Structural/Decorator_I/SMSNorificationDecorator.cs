namespace Decorator_I;

internal class SMSNorificationDecorator : BaseDecorator, INotification
{
    public SMSNorificationDecorator(INotification notification) : base(notification)
    {
    }

    public void SendNotification()
    {
        if (null != _notification)
        {
            _notification.SendNotification();
        }

        Console.WriteLine("SMS notification sent!");
    }
}
