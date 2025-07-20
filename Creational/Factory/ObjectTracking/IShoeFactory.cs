namespace ObjectTracking
{
    public interface IShoeFactory
    {
        IShoe CreateShoe(int size, string color, string name, string shoeType);

        List<IShoe> GetAliveShoes();
    }
}
