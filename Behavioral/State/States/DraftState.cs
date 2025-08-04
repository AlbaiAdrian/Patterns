namespace State.States;

class DraftState : IDocumentState
{
    public void Publish(DocumentContext context)
    {
        Console.WriteLine("Document submitted for moderation.");
        context.TransitionTo(new ModerationState());
    }

    public void Reject(DocumentContext context)
    {
        Console.WriteLine("Cannot reject a draft.");
    }

    public string GetName() => "Draft";
}
