// See https://aka.ms/new-console-template for more information
using AbstractFactory.Client;
using AbstractFactory.Factories.Implementations;

Console.WriteLine("Hello, Abstract Factories!");

Console.WriteLine("");

var macFactory = new MacFactory();
var macClient = new GUIClient(macFactory);
macClient.Paint();

Console.WriteLine("-----------------------------");

var winFactory = new WindowsFactory();
var winClient = new GUIClient(winFactory);
winClient.Paint();

