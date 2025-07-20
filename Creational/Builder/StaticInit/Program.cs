// See https://aka.ms/new-console-template for more information
using StaticInit;

Console.WriteLine("Hello, Static init!");

Person person = PersonBuilder.Create()
            .WithFirstName("John")
            .WithLastName("Doe")
            .WithAge(30)
            .Build();

Console.WriteLine($"{person.FirstName} {person.LastName}, Age {person.Age}");


Person person1 = PersonBuilder.Create()
            .WithLastName("Doe")
            .WithAge(30)
            .WithFirstName("John")
            .Build();

Console.WriteLine($"{person1.FirstName} {person1.LastName}, Age {person1.Age}");
