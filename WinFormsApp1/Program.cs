using GeographicProjections.Conroller;
using GeographicProjections.Projections;
using System.Drawing.Imaging;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


            MapController mapController = new MapController();

            // Use the mapController to render the map...
            // You'll need to create a Bitmap and an IProjection to pass to the RenderMap method.
            Bitmap bitmap = new Bitmap(800, 600); // Example bitmap size
            IProjection projection = new Equirectangular(); // Example projection

            mapController.RenderMap(projection, bitmap).Wait(); // Wait for the rendering to complete

            // Save the bitmap to a file, display it in a window, etc.
            bitmap.Save("map.png", ImageFormat.Png);
        }
    }
}