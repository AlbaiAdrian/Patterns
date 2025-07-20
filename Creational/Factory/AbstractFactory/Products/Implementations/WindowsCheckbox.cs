using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products.Implementations;

public class WindowsCheckbox : ICheckbox
{
    public void Paint() => Console.WriteLine("Rendering a Windows checkbox.");
}
