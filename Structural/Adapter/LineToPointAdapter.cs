using System.Collections.ObjectModel;

namespace Adapter;

public class LineToPointAdapter : Collection<Point>
{
    private readonly Line _line;

    private static Dictionary<Line, List<Point>> _cache = new();

    public LineToPointAdapter(Line line)
    {
        _line = line;
        if (_cache.ContainsKey(line)) {
            return;
        }
        List<Point> points = new List<Point>(); 
        for (int x = line.Start.X; x <= line.End.X; x++)
        {
            for (int y = line.Start.Y; y <= line.End.Y; y++)
            {
                points.Add(new Point(x, y));
            }
        }

        _cache.Add(line, points);    
    }

    public IEnumerator<Point> GetEnumerator() {
        return _cache[_line].GetEnumerator();
    }
}
