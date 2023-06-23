using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeographicProjections.Rendering;

namespace GeographicProjections.Projections
{
    public class Coordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Coordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        // Convert this Coordinate to a Point3D
        public Rendering.Point3D ToPoint3D()
        {
            // Convert latitude and longitude to radians
            double latRad = Latitude * Math.PI / 180;
            double lonRad = Longitude * Math.PI / 180;

            // Convert spherical coordinates to Cartesian coordinates
            double x = Math.Cos(latRad) * Math.Cos(lonRad);
            double y = Math.Cos(latRad) * Math.Sin(lonRad);
            double z = Math.Sin(latRad);

            return new Point3D(x, y, z);
        }
    }
}
