using GeographicProjections.Projections;
using GeographicProjections.Rendering;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicProjections.Geometry
{




    public class ShorelineData
    {

        public async Task<List<Projections.Coordinate>> GetShorelineDataAsync()
        {
            try
            {
                string projectDirectory = Directory.GetCurrentDirectory();
                string dataFilePath = Path.Combine(projectDirectory, "Data", "ShorelineData.json");
                Console.WriteLine(dataFilePath);
                var json = await File.ReadAllTextAsync(dataFilePath);

                var shorelineData = JsonConvert.DeserializeObject<Root>(json);

                var coordinates = new List<Projections.Coordinate>();

                foreach (Feature feature in shorelineData.Features)
                {
                    foreach (List<List<double>> polygon in feature.Geometry.Coordinates)
                    {
                        foreach (List<double> point in polygon)
                        {
                            // Create a new Coordinate object for each pair of latitude and longitude values
                            Projections.Coordinate coordinate = new Projections.Coordinate(point[0], point[1]); // Note the indices
                            coordinates.Add(coordinate);
                        }
                    }
                }


                return coordinates;
            }
            catch (Exception ex)
            {
                // Log the exception message
                Console.WriteLine(ex.Message);

                // Rethrow the exception
                throw;
            }
        }

    }
}
