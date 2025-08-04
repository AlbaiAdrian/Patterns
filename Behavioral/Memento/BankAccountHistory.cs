namespace Memento;

class BankAccountHistory
{
    private Stack<IMemento> _history = new Stack<IMemento>();

    public void Push(IMemento memento)
    {
        _history.Push(memento);
    }

    public IMemento Pop()
    {
        return _history.Pop();
    }

    public bool CanUndo => _history.Count > 0;

    public void ShowHistory()
    {
        Console.WriteLine("\n--- History ---");
        foreach (var memento in _history)
        {
            Console.WriteLine(memento.GetName());
        }
        Console.WriteLine("----------------\n");
    }
}
