namespace Decorator_I
{
    internal abstract class BaseDecorator
    {
        protected readonly INotification _notification;

        protected BaseDecorator(INotification notification)
        {
            _notification = notification;
        }
    }
}
