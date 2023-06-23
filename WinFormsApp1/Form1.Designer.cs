using GeographicProjections.Controller;
using GeographicProjections.Projections;
using GeographicProjections.Rendering;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private MapController _mapController;
        private PictureBox pictureBox;

        public Form1()
        {
            //InitializeComponent();

            // Create a new PictureBox
            pictureBox = new PictureBox
            {
                Name = "pictureBox1",
                Size = new Size(800, 600), // Set the size as needed
                Location = new Point(10, 10), // Set the location as needed
                BorderStyle = BorderStyle.Fixed3D
            };

            // Add the PictureBox to the form
            this.Controls.Add(pictureBox);
        }


        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public Form1()
        {
            InitializeComponent();

            IProjection projection = new EquirectangularProjection();
            Renderer renderer = new Renderer();
            ShorelineData shorelineData = new ShorelineData();

            _mapController = new MapController(projection, renderer, shorelineData);
        }

    }
}