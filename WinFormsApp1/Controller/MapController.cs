using GeographicProjections.Geometry;
using GeographicProjections.Projections;
using GeographicProjections.Rendering;

public class MapController
{
    private IProjection projection;
    private Renderer renderer;
    private ShorelineData shorelineData;

    public MapController(IProjection projection, Renderer renderer, ShorelineData shorelineData)
    {
        this.projection = projection;
        this.renderer = renderer;
        this.shorelineData = shorelineData;
    }

    public async Task<Bitmap> RenderMapAsync()
    {
        List<List<Coordinate>> shorelineData = await this.shorelineData.GetShorelineDataAsync(); // <-- Change type here
        return renderer.Render(projection, shorelineData);
    }
}
