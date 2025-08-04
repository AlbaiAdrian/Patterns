using Visitor_I.Nodes;

namespace Visitor_I.Visitors;

class Printer : IExpressionVisitor
{
    public string Result { get; private set; }

    public void Visit(Number number)
    {
        Result = number.Value.ToString();
    }

    public void Visit(Addition addition)
    {
        addition.Left.Accept(this);
        string left = Result;
        addition.Right.Accept(this);
        string right = Result;
        Result = $"({left} + {right})";
    }

    public void Visit(Multiplication multiplication)
    {
        multiplication.Left.Accept(this);
        string left = Result;
        multiplication.Right.Accept(this);
        string right = Result;
        Result = $"({left} * {right})";
    }
}
