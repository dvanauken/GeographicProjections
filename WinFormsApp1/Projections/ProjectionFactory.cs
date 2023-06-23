using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Projections
{
    public class ProjectionFactory
    {
        public IProjection CreateProjection(string projectionType)
        {
            switch (projectionType.ToLower())
            {
                case "equirectangular":
                    return new EquirectangularProjection();
                case "orthographic":
                    return new OrthographicProjection();
                // Add more cases here for other types of projections
                default:
                    throw new ArgumentException($"Unknown projection type: {projectionType}");
            }
        }
    }
}
