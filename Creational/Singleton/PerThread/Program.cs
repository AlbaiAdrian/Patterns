// See https://aka.ms/new-console-template for more information
using PerThread;

Console.WriteLine("Hello, Singleton per Thread!");

List<Task> tasks = new List<Task>();

for (int i = 0; i <= 5; i++)
{
    tasks.Add(Task.Factory.StartNew(() => { Console.WriteLine($"Starting task with thread id {SingletonPerThred.Instance.Id}"); }));
}

Task.WaitAll(tasks);