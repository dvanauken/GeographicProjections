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
        Point3D IProjection.forward(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }

        Coordinate IProjection.inverse(Point3D point)
        {
            throw new NotImplementedException();
        }

    }
}
