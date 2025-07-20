using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products.Implementations;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories.Implementations;

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}
