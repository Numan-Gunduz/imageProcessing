using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static imageProcessing.Histogram;

namespace imageProcessing
{
    public partial class HistogramForm : Form
    {
        private Bitmap originalImage;
        public HistogramForm()
        {
            InitializeComponent();
        }

        private void resimEkleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                pictureBoxOriginal.Image = originalImage;
            }
        }

        private void GermeButton_Click(object sender, EventArgs e)
        {
            int minGray = 0; // Örneğin, 0
            int maxGray = 255; // Örneğin, 255

            Bitmap stretchedImage = HistogramStretch(originalImage, minGray, maxGray);
            pictureBoxTransformed.Image = stretchedImage;
        }

        private void GenisletmeButton_Click(object sender, EventArgs e)
        {
            Bitmap equalizedImage = HistogramEqualize(originalImage);
            pictureBoxTransformed.Image = equalizedImage;
        }
    }
}
