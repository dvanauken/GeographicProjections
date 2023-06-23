using GeographicProjections.Projections;
using GeographicProjections.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeographicProjections.Controller
{
    public class MapController
    {
        private IProjection _projection;
        private Renderer _renderer;
        private ShorelineData _shorelineData;

        public MapController(IProjection projection, Renderer renderer, ShorelineData shorelineData)
        {
            _projection = projection;
            _renderer = renderer;
            _shorelineData = shorelineData;
        }

        public async Task RenderMapAsync()
        {
            List<Coordinate> shoreline = await _shorelineData.GetShorelineDataAsync();
            _renderer.Render(shoreline, _projection);
        }
    }
}
