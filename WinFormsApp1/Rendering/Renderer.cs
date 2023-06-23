using System.Drawing;
using System.Collections.Generic;
using GeographicProjections.Projections;

namespace GeographicProjections.Rendering
{
    public class Renderer : IRenderer
    {
        private int width;
        private int height;

        public Renderer(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void DrawLine(Point3D start, Point3D end)
        {
            throw new NotImplementedException();
        }

        public void DrawPoint(Point3D point)
        {
            throw new NotImplementedException();
        }

        public void DrawPolygon(Polygon polygon)
        {
            throw new NotImplementedException();
        }

        public Bitmap Render(IProjection projection, List<Coordinate> shorelineData)
        {
            // Create a new bitmap to draw on
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Set the background color
                g.Clear(Color.White);

                // Draw the shoreline
                foreach (var coordinate in shorelineData)
                {
                    // Convert the geographic coordinates to screen coordinates
                    Point3D point = projection.Forward(coordinate);

                    // Convert the 3D point to 2D
                    PointF point2D = new PointF((float)point.X, (float)point.Y);

                    // Draw the point on the bitmap
                    g.FillEllipse(Brushes.Black, point2D.X, point2D.Y, 1, 1);
                }
            }

            return bitmap;
        }
    }
}
