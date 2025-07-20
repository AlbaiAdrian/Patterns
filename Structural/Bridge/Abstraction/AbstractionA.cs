namespace Bridge;

public class AbstractionA : Abstraction
{
    public AbstractionA(IImplementation implementation) : base(implementation)
    {
    }

    public override string Operation()
    {
        return "Abstraction A: Extended operation with:\n" + _implementation.OperationImplementation();
    }
}
