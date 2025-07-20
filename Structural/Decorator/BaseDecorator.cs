namespace Decorator;

internal abstract class BaseDecorator
{
    protected readonly IPizza _pizza;

    public BaseDecorator(IPizza pizza)
    {
        _pizza = pizza;
    }
}
