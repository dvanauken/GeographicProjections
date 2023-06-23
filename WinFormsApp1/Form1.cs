using GeographicProjections.Geometry;
using GeographicProjections.Projections;
using GeographicProjections.Rendering;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Form1 : Form
    {
        private PictureBox pictureBox;
        private IProjection projection;
        private ShorelineData shorelineData;

        public Form1()
        {
            // Create a new PictureBox
            pictureBox = new PictureBox
            {
                Name = "pictureBox1",
                Size = new Size(300, 200), // Set the size as needed
                Location = new Point(10, 10), // Set the location as needed
                BorderStyle = BorderStyle.Fixed3D
            };

            // Add the PictureBox to the form
            this.Controls.Add(pictureBox);

            pictureBox.Dock = DockStyle.Fill;

            // Add the Load event handler
            this.Load += new EventHandler(Form1_Load);
            this.Resize += new EventHandler(Form1_Resize);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            projection = new EquirectangularProjection(); // Or any other class that implements IProjection
            Renderer renderer = new Renderer(pictureBox.Width, pictureBox.Height);
            shorelineData = new ShorelineData();

            MapController mapController = new MapController(projection, renderer, shorelineData);
            Bitmap renderedImage = await mapController.RenderMapAsync();
            pictureBox.Image = renderedImage;
        }

        private async void Form1_Resize(object sender, EventArgs e)
        {
            // Don't re-render the map if the form is minimized
            if (this.WindowState == FormWindowState.Minimized)
            {
                return;
            }

            // Create a new Renderer with the new dimensions
            Renderer renderer = new SimpleRenderer(pictureBox.Width, pictureBox.Height);

            // Create a new MapController with the new Renderer
            MapController mapController = new MapController(projection, renderer, shorelineData);

            // Render the map
            //Bitmap renderedImage = mapController.RenderMapAsync().Result;
            Bitmap renderedImage = await mapController.RenderMapAsync();

            // Update the PictureBox's Image
            pictureBox.Image = renderedImage;
        }
    }
}
