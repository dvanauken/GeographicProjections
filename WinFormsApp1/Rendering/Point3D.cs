using GeographicProjections.Projections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Rendering
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Convert this Point3D to a Coordinate
        public Coordinate ToCoordinate()
        {
            // Convert Cartesian coordinates to spherical coordinates
            double lonRad = Math.Atan2(Y, X);
            double latRad = Math.Asin(Z);

            // Convert radians to degrees
            double latitude = latRad * 180 / Math.PI;
            double longitude = lonRad * 180 / Math.PI;

            return new Coordinate(latitude, longitude);
        }
    }
}
