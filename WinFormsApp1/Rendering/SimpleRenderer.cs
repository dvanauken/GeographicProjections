using GeographicProjections.Projections;
using System.Collections.Generic;
using System.Drawing;

namespace GeographicProjections.Rendering
{
    public class SimpleRenderer : Renderer
    {
        public SimpleRenderer(int width, int height) : base(width, height)
        {
        }

        public Bitmap Render(IProjection projection, List<List<Coordinate>> shorelineData)
        {
            // Create a new bitmap to draw on
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Set the background color
                g.Clear(Color.White);

                // Draw each geometry
                foreach (var geometry in shorelineData) // <-- Change: Now looping over each geometry
                {
                    // Initialize the previous point to null
                    PointF? previousPoint = null; // <-- Change: Reset previousPoint for each new geometry

                    // Draw the shoreline for this geometry
                    foreach (var coordinate in geometry)
                    {
                        // Convert the geographic coordinates to screen coordinates
                        Point3D point = projection.Forward(coordinate);

                        // Scale and translate the point to fit into the PictureBox
                        double scaleX = width / (2.0 * Math.PI); // Longitude range is -π to π
                        double scaleY = height / Math.PI; // Latitude range is -π/2 to π/2
                        double translateX = width / 2.0;
                        double translateY = height / 2.0;

                        // Convert the 3D point to 2D
                        PointF point2D = new PointF((float)(point.X * scaleX + translateX), (float)(-point.Y * scaleY + translateY)); // Note the negative sign for y to flip the y-axis

                        // If there is a previous point, draw a line from the previous point to the current point
                        if (previousPoint.HasValue)
                        {
                            g.DrawLine(Pens.Black, previousPoint.Value, point2D);
                        }

                        // Update the previous point
                        previousPoint = point2D;
                    }
                }
            }
            return bitmap;
        }
    }
}
