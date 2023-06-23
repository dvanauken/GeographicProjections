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

    //public class Coordinate
    //{
     //   public double Latitude { get; set; }
    //    public double Longitude { get; set; }
    //}

    public class Geometry
    {
        public string Type { get; set; }
        public List<List<Coordinate>> Coordinates { get; set; }
    }

    public class Feature
    {
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public Dictionary<string, object> Properties { get; set; }
    }

    public class Root
    {
        public string Type { get; set; }
        public List<Feature> Features { get; set; }
    }


    public class ShorelineData
    {
        /*
        public async Task<List<Coordinate>> GetShorelineDataAsyncWeb()
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
        */


        public async Task<List<Coordinate>> GetShorelineDataAsync()
        {
            var json = await File.ReadAllTextAsync("path/to/ShorelineData.json");

            var shorelineData = JsonConvert.DeserializeObject<Root>(json);

            var coordinates = new List<Coordinate>();

            foreach (var feature in shorelineData.Features)
            {
                foreach (var coordinate in feature.Geometry.Coordinates)
                {
                    coordinates.Add(new Coordinate(coordinate[0].Latitude, coordinate[0].Longitude));
                }
            }

            return coordinates;
        }
    }
}
