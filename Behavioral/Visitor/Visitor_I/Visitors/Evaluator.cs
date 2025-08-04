using Visitor_I.Nodes;

namespace Visitor_I.Visitors;

class Evaluator : IExpressionVisitor
{
    public int Result { get; private set; }

    public void Visit(Number number)
    {
        Result = number.Value;
    }

    public void Visit(Addition addition)
    {
        addition.Left.Accept(this);
        int left = Result;
        addition.Right.Accept(this);
        int right = Result;
        Result = left + right;
    }

    public void Visit(Multiplication multiplication)
    {
        multiplication.Left.Accept(this);
        int left = Result;
        multiplication.Right.Accept(this);
        int right = Result;
        Result = left * right;
    }
}
