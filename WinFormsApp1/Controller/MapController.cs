using System.Drawing;
using System.Threading.Tasks;
using GeographicProjections.Projections;
using GeographicProjections.Rendering;

public class MapController
{
    private SimpleRenderer renderer;
    private ShorelineData shorelineData = new ShorelineData();

    public async Task RenderMap(IProjection projection, Bitmap bitmap)
    {
        // Get the shoreline data
        Root shoreline = await shorelineData.GetShorelineDataAsync();

        // Create a Graphics object from the bitmap
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            // Create a pen to draw the shoreline
            using (Pen pen = new Pen(Color.Black))
            {
                // Loop through each feature in the shoreline data
                foreach (var feature in shoreline.Features)
                {
                    // Loop through each coordinate in the feature
                    for (int i = 0; i < feature.Geometry.Coordinates.Count - 1; i++)
                    {
                        // Get the current coordinate and the next coordinate
                        var currentCoordinate = feature.Geometry.Coordinates[i];
                        var nextCoordinate = feature.Geometry.Coordinates[i + 1];

                        // Project the coordinates to the map
                        var currentPoint = projection.Forward(new Coordinate(currentCoordinate[1], currentCoordinate[0]));
                        var nextPoint = projection.Forward(new Coordinate(nextCoordinate[1], nextCoordinate[0]));

                        // Draw a line from the current point to the next point
                        graphics.DrawLine(pen, (float)currentPoint.X, (float)currentPoint.Y, (float)nextPoint.X, (float)nextPoint.Y);
                    }
                }
            }
        }
    }
}
