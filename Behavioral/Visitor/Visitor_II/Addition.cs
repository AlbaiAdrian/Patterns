namespace Visitor_II;

class Addition : IExpression
{
    public IExpression Left { get; }
    public IExpression Right { get; }
    public Addition(IExpression left, IExpression right)
    {
        Left = left;
        Right = right;
    }
}
