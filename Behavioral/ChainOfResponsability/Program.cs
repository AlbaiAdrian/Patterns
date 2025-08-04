// See https://aka.ms/new-console-template for more information
using ChainOfResponsability;

Console.WriteLine("Hello, Chain Of Responsability!");


var goblin = new Goblin();
var orc = new Orc();
var dragon = new Dragon();

goblin.SetNext(orc);
orc.SetNext(dragon);

// Hero with varying strength
var weakHero = new Hero(4);
var averageHero = new Hero(9);
var strongHero = new Hero(15);
var mightyHero = new Hero(25);

Console.WriteLine("== Weak Hero ==");
goblin.HandleRequest(weakHero);

Console.WriteLine("\n== Average Hero ==");
goblin.HandleRequest(averageHero);

Console.WriteLine("\n== Strong Hero ==");
goblin.HandleRequest(strongHero);

Console.WriteLine("\n== Mighty Hero ==");
goblin.HandleRequest(mightyHero);