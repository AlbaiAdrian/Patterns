namespace State.States;

class ModerationState : IDocumentState
{
    public void Publish(DocumentContext context)
    {
        Console.WriteLine("Document approved and published.");
        context.TransitionTo(new PublishedState());
    }

    public void Reject(DocumentContext context)
    {
        Console.WriteLine("Document rejected. Returning to draft.");
        context.TransitionTo(new DraftState());
    }

    public string GetName() => "Moderation";
}
