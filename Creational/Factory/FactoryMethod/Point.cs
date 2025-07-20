namespace FactoryMethod;

public class Point
{
    public double X { get; private set; }

    public double Y { get; private set; }

    private Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Point NewCartesianPoint(double x, double y)
    {
        return new Point(x, y);
    }

    public static Point NewPolarPoint(double radDist, double theta)
    {
        return new Point(radDist * Math.Cos(theta), radDist * Math.Sin(theta));
    }

}