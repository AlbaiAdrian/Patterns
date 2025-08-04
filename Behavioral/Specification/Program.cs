// See https://aka.ms/new-console-template for more information


using OpenCloseBookExample_I.Entities;
using OpenCloseBookExample_I.Enums;
using OpenCloseBookExample_I.Filter;
using OpenCloseBookExample_I.Filter.Specification;

var apple = new Product() { Name = "Apple", Color = Color.Green, Size = Size.Small };
var tree = new Product() { Name = "Tree", Color = Color.Green, Size = Size.Large };
var house = new Product() { Name = "House", Color = Color.Blue, Size = Size.Large };

Product[] products = { apple, tree, house };

var filter = new GeneralFilter<Product>();

Console.WriteLine("Green products:");
var colorSpec = new ColorSpecification(Color.Green);
foreach (var p in filter.Filter(products, colorSpec))
{
    Console.WriteLine($" - {p.Name} is green");
}

Console.WriteLine(Environment.NewLine);

Console.WriteLine("Large products:");
var sizeSpec = new SizeSpecification(Size.Large);
foreach (var p in filter.Filter(products, sizeSpec))
{
    Console.WriteLine($" - {p.Name} is large");
}

Console.WriteLine(Environment.NewLine);

Console.WriteLine("Green and large products:");
var andSpec = new AndSpecification<Product>(colorSpec, sizeSpec );
foreach (var p in filter.Filter(products, andSpec))
{
    Console.WriteLine($" - {p.Name} is green and large");
}