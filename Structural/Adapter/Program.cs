// See https://aka.ms/new-console-template for more information
using Adapter;
using System.Drawing.Text;

Console.WriteLine("Hello, World!");
List<VectorObject> vectorObjects = new() { new VectorRectangle(1, 1, 100, 100), new VectorRectangle(3, 3, 60, 60) };

DrawVectorObjects();

vectorObjects.Add(new VectorRectangle(300,300, 400, 400));

DrawVectorObjects();

Draw.SaveBitmap();

void DrawVectorObjects() {
    foreach (var vo in vectorObjects)
    {
        foreach (var line in vo)
        {
            var adapter = new LineToPointAdapter(line);
            foreach (Point point in adapter)
            {
                Draw.DrawPoint(point);
            }
        }
    }
}