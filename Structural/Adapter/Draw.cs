using System.Drawing;

namespace Adapter;

public static class Draw
{
    static Bitmap _bitmap = new Bitmap(1024, 1024);

    public static void DrawPoint(Point p)
    {
        _bitmap.SetPixel(p.X, p.Y, Color.Red);
    }

    public static void SaveBitmap()
    {
        _bitmap.Save("Drawedimage.png");
    }
}
