namespace Composite_I;

public class Product : IPrice
{
    private readonly int _price;

    public Product(int price)
    {
        _price = price;
    }

    public int GetPrice()
    {
        return _price;
    }
}
