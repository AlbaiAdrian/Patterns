namespace Composite_I;

public class Box : IPrice
{
    private readonly List<IPrice> _items = new List<IPrice>();
    private readonly int _price;

    public Box(int price = 0)
    {
        _price = price;
    }

    public void Add(IPrice item)
    {
        _items.Add(item);
    }

    public void Remove(IPrice item)
    {
        _items.Remove(item);
    }

    public int GetPrice()
    {
        int price = _price;

        foreach (IPrice item in _items) {
            price += item.GetPrice();
        }

        return price;
    }
}
