using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageProcessing
{
    public partial class ArithmeticOperationsForm : Form
    {
        private Bitmap firstImage;
        private Bitmap secondImage;
        private bool isFirstImageSelected = false;
        public ArithmeticOperationsForm()
        {
            InitializeComponent();
        }

        private void resimEkleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap selectedImage = new Bitmap(openFileDialog.FileName);

                if (!isFirstImageSelected)
                {
                    firstImage = selectedImage;
                    pictureBox1.Image = firstImage;
                    isFirstImageSelected = true;
                }
                else
                {
                    secondImage = selectedImage;
                    pictureBox2.Image = secondImage;
                    isFirstImageSelected = false;
                }
            }
        }

        private void eklemeButton_Click(object sender, EventArgs e)
        {
            if (firstImage != null && secondImage != null)
            {
                Bitmap resultImage = AritmetikIslemler.AddImages(firstImage, secondImage);
                pictureBoxResult.Image = resultImage;
            }
            else
            {
                MessageBox.Show("Please select both images before applying the operation.");
            }
        }

        private void carpmaButton_Click(object sender, EventArgs e)
        {
            if (firstImage != null && secondImage != null)
            {
                Bitmap resultImage = AritmetikIslemler.MultiplyImages(firstImage, secondImage);
                pictureBoxResult.Image = resultImage;
            }
            else
            {
                MessageBox.Show("Please select both images before applying the operation.");
            }
        }

        private void ArithmeticOperationsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
