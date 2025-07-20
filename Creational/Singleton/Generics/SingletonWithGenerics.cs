namespace Generics;

internal abstract class SingletonWithGenerics<T> where T : class
{

    private static Lazy<T> _instance = new Lazy<T>(() => Activator.CreateInstance(typeof(T), true) as T);

    public static T Instance => _instance.Value;
}
