using GeographicProjections.Controller;
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

            // Add the Load event handler
            this.Load += new EventHandler(Form1_Load);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            IProjection projection = new EquirectangularProjection(); // Or any other class that implements IProjection
            Renderer renderer = new Renderer(800, 600); // Pass the correct PictureBox
            ShorelineData shorelineData = new ShorelineData();

            MapController mapController = new MapController(projection, renderer, shorelineData);
            Bitmap renderedImage = await mapController.RenderMapAsync();
            pictureBox.Image = renderedImage;
        }
    }
}
