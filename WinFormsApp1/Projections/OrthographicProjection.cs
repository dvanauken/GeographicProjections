using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeographicProjections.Projections;
using GeographicProjections.Rendering;

namespace GeographicProjections.Projections
{
    public class OrthographicProjection : IProjection
    {
        // Radius of the Earth in meters
        private const double R = 1; //6378137;

        public Point3D Forward(Coordinate coord)
        {
            double lonRad = coord.Longitude * Math.PI / 180;
            double latRad = coord.Latitude * Math.PI / 180;

            double x = R * Math.Cos(latRad) * Math.Cos(lonRad);
            double y = R * Math.Cos(latRad) * Math.Sin(lonRad);
            double z = R * Math.Sin(latRad);

            return new Point3D(x, y, z);
        }

        public Coordinate Inverse(Point3D point)
        {
            double lonDeg = Math.Atan2(point.Y, point.X) * 180 / Math.PI;
            double latDeg = Math.Asin(point.Z / R) * 180 / Math.PI;

            return new Coordinate(latDeg, lonDeg);
        }
    }

}
