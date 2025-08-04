using Visitor_I.Visitors;

namespace Visitor_I.Nodes;

interface IExpression
{
    void Accept(IExpressionVisitor visitor);
}