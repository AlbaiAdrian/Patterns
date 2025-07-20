// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");


ConcreteImplementationA concreteImplementationA = new ConcreteImplementationA();
Abstraction abstractionA= new AbstractionA(concreteImplementationA);
Console.WriteLine(abstractionA.Operation());

Console.WriteLine();    

ConcreteImplementationB concreteImplementationB = new ConcreteImplementationB();
Abstraction abstractionB = new AbstractionB(concreteImplementationB);
Console.WriteLine(abstractionB.Operation());

Console.WriteLine();

Abstraction abstractionA1 =  new AbstractionA(concreteImplementationB);
Console.WriteLine(abstractionA1.Operation());