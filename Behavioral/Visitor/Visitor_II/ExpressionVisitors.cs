namespace Visitor_II;

static class ExpressionVisitors
{
    public static int Evaluate(this IExpression expr)
    {
        switch (expr)
        {
            case Number n:
                return n.Value;

            case Addition a:
                return a.Left.Evaluate() + a.Right.Evaluate();

            case Multiplication m:
                return m.Left.Evaluate() * m.Right.Evaluate();

            default:
                throw new NotSupportedException("Unknown expression");
        }
    }

    public static string Print(this IExpression expr)
    {
        return expr switch
        {
            Number n => n.Value.ToString(),
            Addition a => $"({a.Left.Print()} + {a.Right.Print()})",
            Multiplication m => $"({m.Left.Print()} * {m.Right.Print()})",
            _ => throw new NotSupportedException("Unknown expression")
        };
    }
}
