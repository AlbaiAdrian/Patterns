using State.States;

namespace State;

class DocumentContext
{
    private IDocumentState _state;

    public DocumentContext()
    {
        _state = new DraftState();
        Console.WriteLine($"New document created. Current state: {_state.GetName()}");
    }

    public void TransitionTo(IDocumentState state)
    {
        _state = state;
        Console.WriteLine($"State changed to: {_state.GetName()}");
    }

    public void Publish()
    {
        _state.Publish(this);
    }

    public void Reject()
    {
        _state.Reject(this);
    }

    public string GetStateName()
    {
        return _state.GetName();
    }
}
