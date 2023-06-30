using GeographicProjections.Projections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Rendering
{

    public class Polygon
    {
        public List<Coordinate> Vertices { get; set; }

        public Polygon()
        {
            Vertices = new List<Coordinate>();
        }

        public double Area()
        {
            // TODO: Implement the calculation of the area of the polygon
            throw new NotImplementedException();
        }

        public bool ContainsPoint(Coordinate point)
        {
            // TODO: Implement the point-in-polygon algorithm
            throw new NotImplementedException();
        }
    }


}
