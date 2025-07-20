using Stepwise.Steps;

namespace Stepwise;

public class CarBuilder : ICarTypeStep, IEngineStep, ITransmissionStep, IBuildStep
{
    private Car _car = new Car();

    private CarBuilder() { }

    // Notice the static initializer to return the first step
    public static ICarTypeStep CreateBuilder()
    {
        return new CarBuilder();
    }

    public IEngineStep SetType(string type)
    {
        _car.Type = type;
        return this;
    }

    public ITransmissionStep SetEngine(string engine)
    {
        _car.Engine = engine;
        return this;
    }

    public IBuildStep SetTransmission(string transmission)
    {
        _car.Transmission = transmission;
        return this;
    }

    public Car Build()
    {
        return _car;
    }
}
