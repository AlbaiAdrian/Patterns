namespace PerThread;

internal class SingletonPerThred
{
    private static ThreadLocal<SingletonPerThred> _instance = new ThreadLocal<SingletonPerThred>(() => new SingletonPerThred());

    internal static SingletonPerThred Instance => _instance.Value;

    internal int Id { get; private set; }

    private SingletonPerThred()
    {
        Id = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine($"Created singleton on thred id = {Id}");

    }

}
