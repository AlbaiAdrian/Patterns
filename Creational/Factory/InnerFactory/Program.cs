// See https://aka.ms/new-console-template for more information
using InnerFactory;

Console.WriteLine("Hello, Inner Factory!");

double theta = 90 * (Math.PI / 180);

var polarPoint = Point.Factory.NewPolarPoint(5.0, theta);
Console.WriteLine($"Created polar point with cartesian coordinates X={polarPoint.X} Y={polarPoint.Y}");

var cartesianPoint = Point.Factory.NewCartesianPoint(5, 5);
Console.WriteLine($"Created cartesian point X={polarPoint.X} Y={polarPoint.Y}");