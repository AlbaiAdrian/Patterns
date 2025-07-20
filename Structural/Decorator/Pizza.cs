namespace Decorator;

internal class Pizza : IPizza
{
    public void AddTopping()
    {
        Console.WriteLine("Mozzarella");
    }
}
