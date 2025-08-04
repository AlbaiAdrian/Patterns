namespace State.States;

class PublishedState : IDocumentState
{
    public void Publish(DocumentContext context)
    {
        Console.WriteLine("Document is already published.");
    }

    public void Reject(DocumentContext context)
    {
        Console.WriteLine("Cannot reject a published document.");
    }

    public string GetName() => "Published";
}
