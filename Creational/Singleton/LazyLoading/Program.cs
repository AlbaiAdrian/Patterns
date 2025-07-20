// See https://aka.ms/new-console-template for more information
using LazyLoading;

Console.WriteLine("Hello Lazy Loading!");

var inst = SingletonLazyLoading.Instance;

Console.WriteLine("Instance was created!");

inst.DoSomething();
