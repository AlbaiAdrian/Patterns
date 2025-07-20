namespace LazyLoading
{
    internal class SingletonLazyLoading
    {

        private static Lazy<SingletonLazyLoading> _instance = new Lazy<SingletonLazyLoading>(() => new SingletonLazyLoading());

        public static SingletonLazyLoading Instance => _instance.Value;

        private SingletonLazyLoading()
        {
            Console.WriteLine("Init SingletonExample -> Expensive action perfomed");
        }

        public void DoSomething()
        {
            Console.WriteLine("Perform action SingletonExample");
        }
    }
}
