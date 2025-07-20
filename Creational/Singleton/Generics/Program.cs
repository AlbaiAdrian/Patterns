// See https://aka.ms/new-console-template for more information
using Generics;

Console.WriteLine("Hello, Generics!");

//Console.WriteLine("Calling SingletonWithGenerics<Example1>.Instance!");
//SingletonWithGenerics<Example1>.Instance.ToString();


//Console.WriteLine("Calling again SingletonWithGenerics<Example1>.Instance!");
//SingletonWithGenerics<Example1>.Instance.ToString();

Console.WriteLine("---------------------------------------");

Console.WriteLine("Calling again SingletonWithGenerics<Example2>.Instance!");
SingletonWithGenerics<Example2>.Instance.ToString();

Console.WriteLine("Calling again SingletonWithGenerics<Example2>.Instance!");
SingletonWithGenerics<Example2>.Instance.ToString();

Console.WriteLine("---------------------------------------");

Console.WriteLine("Calling again SingletonExample1!");
SingletonExample1.Instance.ToString();

Console.WriteLine("Calling again SingletonExample1!");
SingletonExample1.Instance.ToString();

