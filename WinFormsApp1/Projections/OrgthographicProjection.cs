using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Rendering;

namespace WinFormsApp1.Projections
{
    internal class OrgthographicProjection : IProjection
    {
        public OrgthographicProjection()
        {
        }

        Rendering.Point IProjection.Project(Rendering.Point point)
        {
            throw new NotImplementedException();
        }
    }
}
