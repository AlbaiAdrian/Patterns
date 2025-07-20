namespace Facade_I;

internal class Facade
{
    private readonly System1 _system1;
    private readonly System2 _system2;

    public Facade(System1 system1, System2 system2)
    {
        _system1 = system1;
        _system2 = system2;
    }

    public void DoMySomething()
    {
        Console.WriteLine(_system2.DoSometring3());
        Console.WriteLine(_system1.DoSomething2());
        Console.WriteLine(_system1.DoSomething1());
    }
}
