// See https://aka.ms/new-console-template for more information
using State;

Console.WriteLine("Hello, State!");


var document = new DocumentContext();

document.Publish(); // Move to Moderation
document.Publish(); // Move to Published
document.Reject();  // Invalid in Published

Console.WriteLine("\n--- Another Document Flow ---\n");

var document2 = new DocumentContext();
document2.Publish(); // Move to Moderation
document2.Reject();  // Back to Draft