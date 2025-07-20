namespace Bridge;

// You can extend the Abstraction without changing the Implementation
// classes.
class AbstractionB : Abstraction
{
    public AbstractionB(IImplementation implementation) : base(implementation)
    {
    }

    public override string Operation()
    {
        return "Abstraction B: Extended operation with:\n" + _implementation.OperationImplementation();
    }
}
