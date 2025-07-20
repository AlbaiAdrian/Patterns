using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Client;

public class GUIClient
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;

    public GUIClient(IGUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void Paint()
    {
        _button.Paint();
        _checkbox.Paint();
    }
}
