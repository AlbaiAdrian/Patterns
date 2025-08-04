// See https://aka.ms/new-console-template for more information
using Visitor_I.Nodes;
using Visitor_I.Visitors;

Console.WriteLine("Hello, Visitor!");

IExpression expr = new Multiplication(
            new Addition(new Number(5), new Number(3)),
            new Number(2)
        );

// Evaluate
var eval = new Evaluator();
expr.Accept(eval);
Console.WriteLine("Result = " + eval.Result); // 16

// Print
var printer = new Printer();
expr.Accept(printer);
Console.WriteLine("Expression = " + printer.Result); // ((5 + 3) * 2)