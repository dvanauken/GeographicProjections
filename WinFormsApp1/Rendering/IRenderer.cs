using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Rendering
{
    public interface IRenderer
    {
        void DrawPoint(Point point);
        void DrawLine(Point start, Point end);
        void DrawPolygon(Polygon polygon);
    }
}
