// See https://aka.ms/new-console-template for more information
using Adapter_I;

Console.WriteLine("Hello, World!");

RoundHole roundHole = new RoundHole(5);
RoundPeg roundpeg = new RoundPeg(5);
Console.WriteLine($"Peg with radius {roundpeg.Radius} fits in hole with radius {roundHole.Radius} = {roundHole.PegFits(roundpeg)}");
Console.WriteLine("");

RoundPeg roundpeg1 = new RoundPeg(6);
Console.WriteLine($"Peg with radius {roundpeg1.Radius} fits in hole with radius {roundHole.Radius} = {roundHole.PegFits(roundpeg1)}");
Console.WriteLine("");

SquarePeg squarePeg = new SquarePeg(7);
SquarePegAdapter squarePegAdapter =  new SquarePegAdapter(squarePeg);
Console.WriteLine($"Square peg with side {squarePeg.Side} fits in hole with radius {roundHole.Radius} = {roundHole.PegFits(squarePegAdapter)}");
Console.WriteLine("");

SquarePeg squarePeg1 = new SquarePeg(9);
SquarePegAdapter squarePegAdapter1 = new SquarePegAdapter(squarePeg1);
Console.WriteLine($"Square peg with side {squarePeg1.Side} fits in hole with radius {roundHole.Radius} = {roundHole.PegFits(squarePegAdapter1)}");

