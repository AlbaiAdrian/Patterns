using Proxy_I;

IOperation operation = new Operation();
IOperation operationProxy = new OperationProxy(operation);

operationProxy.DoOperation();
Console.WriteLine("-------------------------------");

operationProxy.DoOperation();
Console.WriteLine("-------------------------------");

operationProxy.DoOperation();
Console.WriteLine("-------------------------------");