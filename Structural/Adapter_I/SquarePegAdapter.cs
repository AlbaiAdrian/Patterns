namespace Adapter_I;

public class SquarePegAdapter : RoundPeg
{
    private readonly SquarePeg _squarePeg;

    public SquarePegAdapter(SquarePeg squarePeg) : base(0)
    {
        _squarePeg = squarePeg;
        // Egear calculation
        var radius = Math.Sqrt(2 * _squarePeg.Side * _squarePeg.Side) / 2;
        if (Math.Ceiling(radius) - radius < 0.1)
        {
            Radius = Convert.ToInt32(Math.Ceiling(radius));
            return;
        }
        Radius = -1;
    }
}