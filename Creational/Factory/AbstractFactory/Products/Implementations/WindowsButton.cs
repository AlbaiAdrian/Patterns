using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products.Implementations;

public class WindowsButton : IButton
{
    public void Paint() => Console.WriteLine("Rendering a Windows button.");
}
