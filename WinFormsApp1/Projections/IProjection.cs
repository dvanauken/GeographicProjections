using GeographicProjections.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Projections
{
    public interface IProjection
    {
        Point3D forward(Coordinate coordinate);

        Coordinate inverse(Point3D point);
    }
}
