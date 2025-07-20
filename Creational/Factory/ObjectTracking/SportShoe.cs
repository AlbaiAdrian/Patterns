namespace ObjectTracking;

public class SportShoe : IShoe
{
    public int Size { get; set; }
    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; private set; }

    internal SportShoe(int size, string color, string name) { 
        Size = size;
        Color = color;
        Name = name;
        Type = "Sport shoe";
    }
}
