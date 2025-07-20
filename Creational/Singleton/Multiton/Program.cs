// See https://aka.ms/new-console-template for more information
using Multiton;

Console.WriteLine("Hello, Multition!");

Console.WriteLine("Call Choice1");
var obj1 = MultitonExample.Get(Choice.Choice1);
Console.WriteLine("Call Choice1 again");
var obj1_1 = MultitonExample.Get(Choice.Choice1);

Console.WriteLine("------------------------");

Console.WriteLine("Call Choice2");
var obj2 = MultitonExample.Get(Choice.Choice2);
Console.WriteLine("Call Choice2 again");
var obj2_2 = MultitonExample.Get(Choice.Choice2);