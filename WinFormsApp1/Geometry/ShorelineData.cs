using GeographicProjections.Projections;
using GeographicProjections.Rendering;
using Microsoft.Graph;
using Microsoft.Graph.InformationProtection.ThreatAssessmentRequests.Item.Results;
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

        //public async Task<List<Projections.Coordinate>> GetShorelineDataAsync()
        //{
        //    try
        //    {
        //        string projectDirectory = Directory.GetCurrentDirectory();
        //        string dataFilePath = Path.Combine(projectDirectory, "Data", "ShorelineData.json");
        //        Console.WriteLine(dataFilePath);
        //        var json = await File.ReadAllTextAsync(dataFilePath);

        //        var shorelineData = JsonConvert.DeserializeObject<Root>(json);

        //        List<Projections.Coordinate> result = new List<Projections.Coordinate>();

        //        foreach (Feature feature in shorelineData.Features)
        //        {
        //            foreach (List<double> cc in feature.Geometry.Coordinates)
        //            {
        //                // Create a new Coordinate object for each pair of latitude and longitude values
        //                Coordinates c = new Coordinates(cc[1], cc[0]); // Note the indices
        //                Projections.Coordinate coordinate = new Coordinate(cc[1], cc[0]);
        //                Console.WriteLine(coordinate);
        //                result.Add(coordinate);
        //            }
        //        }
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception message
        //        Console.WriteLine(ex.Message);

        //        // Rethrow the exception
        //        throw;
        //    }
        //}

        public async Task<List<List<Projections.Coordinate>>> GetShorelineDataAsync()
        {
            try
            {
                string projectDirectory = Directory.GetCurrentDirectory();
                string dataFilePath = Path.Combine(projectDirectory, "Data", "ShorelineData.json");
                Console.WriteLine(dataFilePath);
                var json = await File.ReadAllTextAsync(dataFilePath);

                var shorelineData = JsonConvert.DeserializeObject<Root>(json);

                List<List<Projections.Coordinate>> result = new List<List<Projections.Coordinate>>();

                foreach (Feature feature in shorelineData.Features)
                {
                    List<Projections.Coordinate> featureCoordinates = new List<Projections.Coordinate>();

                    foreach (List<double> cc in feature.Geometry.Coordinates)
                    {
                        // Create a new Coordinate object for each pair of latitude and longitude values
                        Projections.Coordinate coordinate = new Projections.Coordinate(cc[1], cc[0]); // Note the indices
                        Console.WriteLine(coordinate);
                        featureCoordinates.Add(coordinate);
                    }

                    result.Add(featureCoordinates);
                }

                return result;
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
