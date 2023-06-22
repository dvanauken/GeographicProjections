using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Rendering
{
    public class Polygon
    {
        public List<Point> Points { get; set; }

        public Polygon(List<Point> points)
        {
            Points = points;
        }
    }
}
