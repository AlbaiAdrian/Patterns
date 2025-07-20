using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products.Implementations;

public class MacButton : IButton
{
    public void Paint() => Console.WriteLine("Rendering a Mac button.");
}
