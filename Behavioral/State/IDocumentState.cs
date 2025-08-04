namespace State;

interface IDocumentState
{
    void Publish(DocumentContext context);
    void Reject(DocumentContext context);
    string GetName();
}