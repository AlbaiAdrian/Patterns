namespace InnerFactory;

public partial class Point
{
    public static class Factory
    {

        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double radDist, double theta)
        {
            return new Point(radDist * Math.Cos(theta), radDist * Math.Sin(theta));
        }

    }
}
