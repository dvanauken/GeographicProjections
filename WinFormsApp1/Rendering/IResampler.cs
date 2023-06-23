using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Rendering
{
    public interface IResampler
    {
        Polygon Resample(Polygon polygon);
    }
}
