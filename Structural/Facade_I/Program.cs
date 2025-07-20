// See https://aka.ms/new-console-template for more information
using Facade_I;

System1 system1 = new System1();    
System2 system2 = new System2();    
Facade facade = new Facade(system1, system2);
facade.DoMySomething(); 
Console.ReadLine();
