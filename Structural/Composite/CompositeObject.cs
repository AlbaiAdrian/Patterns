namespace Composite;

public class CompositeObject : Component
{
    private List<Component> _children = new List<Component>();
    private readonly string _name;

    public CompositeObject(string name)
    {
        _name = name;
    }

    public override string Operation()
    {
        string result = "";
        if (Parent == null)
        {
            result = "{";
        }
        result += $"\"{_name}\":{{ ";
        foreach (var child in _children)
        {
            result += child.Operation() + ",";
        }
        result = result.TrimEnd(',');
        result += "}";
        if (Parent == null)
        {
            result += "}";
        }

        return result;
    }

    public override void Add(Component component)
    {
        component.Parent = this;
        _children.Add(component);
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
    }
}
