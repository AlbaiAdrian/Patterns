using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products.Implementations;

public class MacCheckbox : ICheckbox
{
    public void Paint() => Console.WriteLine("Rendering a Mac checkbox.");
}
