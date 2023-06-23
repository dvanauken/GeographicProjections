using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Geometry
{
    public class Geometry
    {
        public string Type { get; set; }
        public List<List<double>> Coordinates { get; set; }
    }
}
