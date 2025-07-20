namespace Adapter_I;

public class RoundHole
{
    private readonly int _radius;

    public RoundHole(int radius)
    {
        _radius = radius;
    }

    public int Radius => _radius;

    public bool PegFits(RoundPeg roundPeg)
    {
        return Radius == roundPeg.Radius;
    }
}
