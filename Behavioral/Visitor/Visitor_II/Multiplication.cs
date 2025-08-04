namespace Visitor_II;

class Multiplication : IExpression
{
    public IExpression Left { get; }
    public IExpression Right { get; }
    public Multiplication(IExpression left, IExpression right)
    {
        Left = left;
        Right = right;
    }
}
