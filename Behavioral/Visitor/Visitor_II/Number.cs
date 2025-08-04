namespace Visitor_II;

class Number : IExpression
{
    public int Value { get; }
    public Number(int value) => Value = value;
}
