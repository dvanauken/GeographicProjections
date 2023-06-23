using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Rendering
{
    public class Polygon
    {
        public List<Point3D> Points { get; set; }

        public Polygon(List<Point3D> points)
        {
            Points = points;
        }
    }
}
