using Visitor_I.Visitors;

namespace Visitor_I.Nodes;

class Number : IExpression
{
    public int Value { get; }
    public Number(int value) => Value = value;

    public void Accept(IExpressionVisitor visitor) => visitor.Visit(this);
}