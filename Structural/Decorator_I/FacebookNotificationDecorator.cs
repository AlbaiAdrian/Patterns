namespace Decorator_I;

internal class FacebookNotificationDecorator : BaseDecorator, INotification
{
    public FacebookNotificationDecorator(INotification notification) : base(notification)
    {
    }

    public void SendNotification()
    {
        if (null != _notification)
        {
            _notification.SendNotification();
        }

        Console.WriteLine("Facebook notification sent!");
    }
}
