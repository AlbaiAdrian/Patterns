namespace ObjectTracking;

public class FancyShoe : IShoe
{
    public int Size { get; set; }
    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; private set; }

    internal FancyShoe(int size, string color, string name) { 
        Size = size;
        Color = color;
        Name = name;
        Type = "Fancy shoe";
    }
}
