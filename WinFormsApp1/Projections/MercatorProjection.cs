using GeographicProjections.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Projections
{
    public class MercatorProjection : IProjection
    {
        // Radius of the Earth in meters
        private const double R = 6378137;

        public Point3D Forward(Coordinate coord)
        {
            double lonRad = coord.Longitude * Math.PI / 180;
            double latRad = coord.Latitude * Math.PI / 180;

            double x = R * lonRad;
            double y = R * Math.Log(Math.Tan(Math.PI / 4 + latRad / 2));

            return new Point3D(x, y, 0);
        }

        public Coordinate Inverse(Point3D point)
        {
            double lonDeg = point.X * 180 / (Math.PI * R);
            double latDeg = (2 * Math.Atan(Math.Exp(point.Y / R)) - Math.PI / 2) * 180 / Math.PI;

            return new Coordinate(latDeg, lonDeg);
        }
    }
}
