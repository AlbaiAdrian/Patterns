namespace Multiton;

internal class MultitonExample
{
    private static Dictionary<Choice, MultitonExample> _instances = new Dictionary<Choice, MultitonExample>();

    public static MultitonExample Get(Choice choice)
    {
        if (_instances.ContainsKey(choice))
        {
            return _instances[choice];
        }

        var new_instance = new MultitonExample(choice);
        _instances[choice] = new_instance;
        return new_instance;

    }

    private MultitonExample(Choice choice)
    {
        Console.WriteLine($"Multiton initialized for {choice}");
    }
}
