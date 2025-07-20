namespace ObjectTracking;

public class ShoeFactory : IShoeFactory
{
    // TODO ADIA :Discuss WeakReference
    private readonly List<WeakReference<IShoe>> _producedShoes = new List<WeakReference<IShoe>>();

    public IShoe CreateShoe(int size, string color, string name, string shoeType)
    {

        switch (shoeType)
        {
            case "Fancy shoe":
                var fancyShoe = new FancyShoe(size, color, name);
                _producedShoes.Add(new WeakReference<IShoe>(fancyShoe));
                return fancyShoe;
            case "Sport shoe":
                var sportShoe = new SportShoe(size, color, name);
                _producedShoes.Add(new WeakReference<IShoe>(sportShoe));
                return sportShoe;
            default:
                throw new ArgumentOutOfRangeException(shoeType);
        }
    }

    public List<IShoe> GetAliveShoes()
    {
        List<IShoe> shoes = new List<IShoe>();
        foreach (var weeekRefShoe in _producedShoes)
        {
            if (weeekRefShoe.TryGetTarget(out var shoe))
            {
                shoes.Add(shoe);
            }
        }
        return shoes;

    }
}
