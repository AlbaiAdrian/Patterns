using Visitor_I.Nodes;

namespace Visitor_I.Visitors;

interface IExpressionVisitor
{
    void Visit(Number number);
    void Visit(Addition addition);
    void Visit(Multiplication multiplication);
}
