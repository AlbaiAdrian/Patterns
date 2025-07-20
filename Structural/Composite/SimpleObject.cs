namespace Composite;

public class SimpleObject : Component
{
    private readonly string _name;
    private readonly string _value;

    public SimpleObject(string name, string value)
    {
        _name = name;
        _value = value;
    }
    public override string Operation()
    {
        if (Parent == null) {
            return $"{{\"{_name}\":\"{_value}\"}}";
        }
        return $"\"{_name}\":\"{_value}\"";
    }
}
