using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Rendering
{
    public class SimpleRenderer : IRenderer
    {
        public void DrawPoint(Point3D point)
        {
            // This is a simple implementation that just prints the point to the console.
            // In a real renderer, you would draw the point on a graphics surface here.
            Console.WriteLine($"Point: ({point.X}, {point.Y})");
        }

        public void DrawLine(Point3D start, Point3D end)
        {
            // This is a simple implementation that just prints the line to the console.
            // In a real renderer, you would draw the line on a graphics surface here.
            Console.WriteLine($"Line: ({start.X}, {start.Y}) to ({end.X}, {end.Y})");
        }

        public void DrawPolygon(Polygon polygon)
        {
            // This is a simple implementation that just prints the polygon to the console.
            // In a real renderer, you would draw the polygon on a graphics surface here.
            Console.WriteLine("Polygon:");
            foreach (var point in polygon.Points)
            {
                Console.WriteLine($"  Point: ({point.X}, {point.Y})");
            }
        }
    }
}
