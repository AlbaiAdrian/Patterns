// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");

Pizza basePizza = new Pizza();
BaconTopping baconTopping = new BaconTopping(basePizza);
CherryTomatoesTopping cherryTopping = new CherryTomatoesTopping(baconTopping);

cherryTopping.AddTopping();

Console.ReadLine();