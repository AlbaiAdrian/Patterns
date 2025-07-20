// See https://aka.ms/new-console-template for more information
using Monostate;

Console.WriteLine("Hello, This is the borg, resitance is futile!");

var obj1 = new MonostateExample();
obj1.Prop1 = "Gigel";
obj1.Prop2 = "Ionel";

Console.WriteLine($"Obj1.Prop1 = {obj1.Prop1} Obj1.Prop2 = {obj1.Prop2}");

var obj2 = new MonostateExample();
Console.WriteLine($"Obj2.Prop1 = {obj1.Prop1} Obj2.Prop2 = {obj1.Prop2}");

var obj3 = new MonostateExample();
Console.WriteLine($"Obj3.Prop1 = {obj1.Prop1} Obj3.Prop2 = {obj1.Prop2}");
