using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Rendering
{
    public interface IRenderer
    {
        void DrawPoint(Point3D point);
        void DrawLine(Point3D start, Point3D end);
        void DrawPolygon(Polygon polygon);
    }
}
