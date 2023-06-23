using GeographicProjections.Controller;
using GeographicProjections.Geometry;
using GeographicProjections.Projections;
using GeographicProjections.Rendering;
using System.Drawing.Imaging;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


            IProjection projection = new EquirectangularProjection(); // Or any other class that implements IProjection
            Renderer renderer = new Renderer(800, 600); // Or any other width and height values you want
            ShorelineData shorelineData = new ShorelineData();

            MapController mapController = new MapController(projection, renderer, shorelineData);

            await mapController.RenderMapAsync();
        }
    }
}