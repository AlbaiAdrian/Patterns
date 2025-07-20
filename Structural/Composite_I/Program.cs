// See https://aka.ms/new-console-template for more information
using Composite_I;

Console.WriteLine("Hello, World!");


IPrice product = new Product(25);

Console.WriteLine($"Single product price {product.GetPrice()}");
Console.WriteLine();

Box bigBox = new Box(1);

Product product1 = new Product(25);
Product product2 = new Product(26);

bigBox.Add(product1);
bigBox.Add(product2);

Box smallBox = new Box();
Product product3 = new Product(27);
smallBox.Add(product3);
bigBox.Add(smallBox);

Console.WriteLine($"Big box price {bigBox.GetPrice()}");

