// See https://aka.ms/new-console-template for more information
using ObjectTracking;

Console.WriteLine("Hello, Object Tracking!");

IShoeFactory shoeFactory = new ShoeFactory();

var fancyShoe = shoeFactory.CreateShoe(42, "red", "supe Red Fancy Shoe", "Fancy shoe");
var sportShoe = shoeFactory.CreateShoe(42, "Blue", "Speedy Gonzales sneakers", "Sport shoe");

foreach (var shoe in shoeFactory.GetAliveShoes())
{
    Console.WriteLine($"size: {shoe.Size} color: {shoe.Color} name: {shoe.Name} shoeType: {shoe.Type}");
}