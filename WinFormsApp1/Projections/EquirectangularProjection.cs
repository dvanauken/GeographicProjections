using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeographicProjections.Projections;
using GeographicProjections.Rendering;

namespace GeographicProjections.Projections
{
    public class EquirectangularProjection : IProjection
    {
        // Radius of the Earth in meters
        //private const double R = 6378137;
        private const double R = 1;

        public Point3D Forward(Coordinate coord)
        {
            double lonRad = coord.Longitude * Math.PI / 180;
            double latRad = coord.Latitude * Math.PI / 180;

            double x = R * lonRad;
            double y = R * latRad;

            return new Point3D(x, y, 0);
        }

        public Coordinate Inverse(Point3D point)
        {
            double lonDeg = point.X * 180 / (Math.PI * R);
            double latDeg = point.Y * 180 / (Math.PI * R);

            return new Coordinate(latDeg, lonDeg);
        }
    }
}
