namespace Adapter;

public class Line
{
    public Point Start { get; set; }
    public Point End;
    // other members omitted

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Line line = (Line)obj;
        return Start.Equals(line.Start) && End.Equals(line.End);
    }
}
