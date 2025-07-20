namespace Decorator;

internal class CherryTomatoesTopping : BaseDecorator, IPizza
{
    public CherryTomatoesTopping(IPizza pizza) : base(pizza)
    {
    }

    public void AddTopping()
    {
        Console.WriteLine("Add cherry tomatoes");
        _pizza.AddTopping();
    }
}
