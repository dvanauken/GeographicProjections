using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox;

        public Form1()
        {
            InitializeComponent();

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
    }
}
