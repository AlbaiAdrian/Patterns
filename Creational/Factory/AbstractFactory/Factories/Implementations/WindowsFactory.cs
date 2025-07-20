using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products.Implementations;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories.Implementations;

public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}