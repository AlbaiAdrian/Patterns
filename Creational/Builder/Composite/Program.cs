// See https://aka.ms/new-console-template for more information
using Composite;

Console.WriteLine("Hello, Composite Builder!");

var pb = new PersonBuilder();
Person person = pb
    .Lives
        .At("123 Main St")
        .In("New York")
        .WithPostcode("10001")
    .Works
        .At("Acme Corp")
        .AsA("Software Engineer")
        .Earning(100)
    .Build();

Console.WriteLine(person);

var pb1 = new PersonBuilder();
Person person1 = pb1
    .Lives
        .At("123 Main St")
    .Works
        .At("Acme Corp")
    .Lives
        .In("New York")
    .Works
        .At("Acme Corp")
    .Lives
        .WithPostcode("10001")
    .Works
        .AsA("Software Engineer")
        .Earning(100)
    .Build();


Console.WriteLine(person1);
