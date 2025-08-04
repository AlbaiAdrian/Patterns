using Visitor_I.Visitors;

namespace Visitor_I.Nodes;

class Multiplication : IExpression
{
    public IExpression Left { get; }
    public IExpression Right { get; }

    public Multiplication(IExpression left, IExpression right)
    {
        Left = left;
        Right = right;
    }

    public void Accept(IExpressionVisitor visitor) => visitor.Visit(this);
}
