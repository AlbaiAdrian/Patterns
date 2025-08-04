namespace Proxy_I;

internal class OperationProxy : IOperation
{
    private readonly IOperation _operation;

    public OperationProxy(IOperation operation)
    {
        _operation = operation;
    }

    void IOperation.DoOperation()
    {
        if (!CheckRights())
        {
            Console.WriteLine("Do not have rights to execute operation");
            return;
        }

        _operation.DoOperation();
    }

    private bool CheckRights()
    {
        Random random = new Random();
        return random.Next(2) == 0;
    }
}
