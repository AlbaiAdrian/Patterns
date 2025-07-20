// See https://aka.ms/new-console-template for more information
using Stepwise;

Console.WriteLine("Hello, Stepwise!");

Car car = CarBuilder.CreateBuilder()
            .SetType("SUV")
            .SetEngine("V8")
            .SetTransmission("Automatic")
            .Build();

Console.WriteLine(car);