namespace Stepwise;

public class Car
{
    public string Type;
    public string Engine;
    public string Transmission;

    public override string ToString()
    {
        return $"{Type} with {Engine} engine and {Transmission} transmission";
    }
}