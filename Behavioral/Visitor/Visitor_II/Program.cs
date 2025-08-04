// See https://aka.ms/new-console-template for more information
using Visitor_II;

Console.WriteLine("Hello, Visitor!");

IExpression expr = new Multiplication(
    new Addition(new Number(5), new Number(3)),
    new Number(2)
);

Console.WriteLine("Expression: " + expr.Print());     // ((5 + 3) * 2)
Console.WriteLine("Result: " + expr.Evaluate());      // 16
