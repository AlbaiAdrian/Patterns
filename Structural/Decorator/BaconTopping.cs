namespace Decorator;

internal class BaconTopping : BaseDecorator, IPizza
{
    public BaconTopping(IPizza pizza) : base(pizza)
    {
    }

    public void AddTopping()
    {
        Console.WriteLine("Add bacon!");
        _pizza.AddTopping();
    }
}
