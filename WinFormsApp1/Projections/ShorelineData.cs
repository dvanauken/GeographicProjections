using Microsoft.Graph;
using Microsoft.Graph.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Projections
{
    public class ShorelineData
    {
        public async Task<List<Coordinate>> GetShorelineDataAsync()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://raw.githubusercontent.com/martynafford/natural-earth-geojson/master/110m/physical/ne_110m_coastline.json");

            var shorelineData = JsonConvert.DeserializeObject<Root>(response);

            var coordinates = new List<Coordinate>();

            foreach (var feature in shorelineData.features)
            {
                foreach (var coordinate in feature.geometry.coordinates)
                {
                    coordinates.Add(new Coordinate(coordinate[1], coordinate[0]));
                }
            }

            return coordinates;
        }
    }
}
