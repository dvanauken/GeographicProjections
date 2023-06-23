using System.Drawing;
using System.Collections.Generic;
using GeographicProjections.Projections;

namespace GeographicProjections.Rendering
{
    public class Renderer : IRenderer
    {
        protected int width;
        protected int height;

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

        //public Bitmap Render(IProjection projection, List<Coordinate> shorelineData)
        //{
        //    //FileStream filestream = new FileStream(@"c:\data\output2.txt", FileMode.Create);
        //    //var streamwriter = new StreamWriter(filestream);
        //    //streamwriter.AutoFlush = true;
        //    //Console.SetOut(streamwriter);
        //    //Console.SetError(streamwriter);
        //    try
        //    {
        //        // Create a new bitmap to draw on
        //        Bitmap bitmap = new Bitmap(width, height);
        //        using (Graphics g = Graphics.FromImage(bitmap))
        //        {
        //            // Set the background color
        //            g.Clear(Color.White);
        //            // Draw the shoreline
        //            foreach (var coordinate in shorelineData)
        //            {
        //                // Convert the geographic coordinates to screen coordinates
        //                Point3D point = projection.Forward(coordinate);
        //                // Scale and translate the point to fit into the PictureBox
        //                double scaleX = width / (2.0 * Math.PI); // Longitude range is -π to π
        //                double scaleY = height / Math.PI; // Latitude range is -π/2 to π/2
        //                double translateX = width / 2.0;
        //                double translateY = height / 2.0;
        //                // Convert the 3D point to 2D
        //                PointF point2D = new PointF((float)(point.X * scaleX + translateX), (float)(-point.Y * scaleY + translateY)); // Note the negative sign for y to flip the y-axis
        //                Console.WriteLine(point2D);
        //                // Draw the point on the bitmap
        //                if (point2D.X >= 0 && point2D.X < width && point2D.Y >= 0 && point2D.Y < height)
        //                {
        //                    g.FillEllipse(Brushes.Black, point2D.X, point2D.Y, 1, 1);
        //                }
        //            }
        //        }
        //        return bitmap;
        //    }
        //    catch (Exception ex) {
        //        // Log the exception message
        //        Console.WriteLine(ex.Message);
        //        // Rethrow the exception
        //        throw;
        //    }
        //    //streamwriter.Close();
        //    //filestream.Close();
        //}

        //public Bitmap Render(IProjection projection, List<Coordinate> shorelineData)
        //{
        //    // Create a new bitmap to draw on
        //    Bitmap bitmap = new Bitmap(width, height);
        //    using (Graphics g = Graphics.FromImage(bitmap))
        //    {
        //        // Set the background color
        //        g.Clear(Color.White);

        //        // Draw the shoreline
        //        foreach (var coordinate in shorelineData)
        //        {
        //            // Convert the geographic coordinates to screen coordinates
        //            Point3D point = projection.Forward(coordinate);

        //            // Scale and translate the point to fit into the PictureBox
        //            double scaleX = width / (2.0 * Math.PI); // Longitude range is -π to π
        //            double scaleY = height / Math.PI; // Latitude range is -π/2 to π/2
        //            double translateX = width / 2.0;
        //            double translateY = height / 2.0;

        //            // Convert the 3D point to 2D
        //            PointF point2D = new PointF((float)(point.X * scaleX + translateX), (float)(-point.Y * scaleY + translateY)); // Note the negative sign for y to flip the y-axis

        //            // Draw the point on the bitmap
        //            if (point2D.X >= 0 && point2D.X < width && point2D.Y >= 0 && point2D.Y < height)
        //            {
        //                g.FillEllipse(Brushes.Black, point2D.X, point2D.Y, 1, 1);
        //            }
        //        }
        //    }

        //    return bitmap;
        //}

        //public Bitmap Render(IProjection projection, List<List<Coordinate>> shorelineData)
        //{
        //    // Create a new bitmap to draw on
        //    Bitmap bitmap = new Bitmap(width, height);
        //    using (Graphics g = Graphics.FromImage(bitmap))
        //    {
        //        // Set the background color
        //        g.Clear(Color.White);

        //        // Draw each geometry
        //        foreach (var geometry in shorelineData) // <-- Change: Now looping over each geometry
        //        {
        //            // Initialize the previous point to null
        //            PointF? previousPoint = null; // <-- Change: Reset previousPoint for each new geometry

        //            // Draw the shoreline for this geometry
        //            foreach (var coordinate in geometry)
        //            {
        //                // Convert the geographic coordinates to screen coordinates
        //                Point3D point = projection.Forward(coordinate);

        //                // Scale and translate the point to fit into the PictureBox
        //                double scaleX = width / (2.0 * Math.PI); // Longitude range is -π to π
        //                double scaleY = height / Math.PI; // Latitude range is -π/2 to π/2
        //                double translateX = width / 2.0;
        //                double translateY = height / 2.0;

        //                // Convert the 3D point to 2D
        //                PointF point2D = new PointF((float)(point.X * scaleX + translateX), (float)(-point.Y * scaleY + translateY)); // Note the negative sign for y to flip the y-axis

        //                // If there is a previous point, draw a line from the previous point to the current point
        //                if (previousPoint.HasValue)
        //                {
        //                    g.DrawLine(Pens.Black, previousPoint.Value, point2D);
        //                }

        //                // Update the previous point
        //                previousPoint = point2D;
        //            }
        //        }
        //    }

        //    return bitmap;
        //}

        public virtual Bitmap Render(IProjection projection, List<List<Coordinate>> shorelineData)
        {
            throw new NotImplementedException();
        }

    }
}
    
