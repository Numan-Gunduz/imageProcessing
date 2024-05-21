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
    public partial class MorphologicalOperationsForm : Form
    {
        private Bitmap originalImage;
        private Bitmap processedImage;
        public MorphologicalOperationsForm()
        {
            InitializeComponent();
        }

        private void resimEkleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.jpeg; *.png; *.gif)|*.bmp; *.jpg; *.jpeg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = originalImage;
            }
        }

        private void GenislemeButton_Click(object sender, EventArgs e)
        {
            int kernelSize = Convert.ToInt32(kernelTextBox.Text);

            if (originalImage == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            if (!int.TryParse(kernelTextBox.Text, out kernelSize))
            {
                MessageBox.Show("Please enter a valid kernel size for dilation.");
                return;
            }

            processedImage = MorfolojikIslemler.Dilate(originalImage, kernelSize);
            pictureBoxResult.Image = processedImage;
        }

        private void AsinmaButton_Click(object sender, EventArgs e)
        {
            int kernelSize = Convert.ToInt32(kernelTextBox.Text);

            if (originalImage == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            if (!int.TryParse(kernelTextBox.Text, out kernelSize))
            {
                MessageBox.Show("Please enter a valid kernel size for erosion.");
                return;
            }

            processedImage = MorfolojikIslemler.Erode(originalImage, kernelSize);
            pictureBoxResult.Image = processedImage;
        }

        private void AcmaButton_Click(object sender, EventArgs e)
        {
            int kernelSize = Convert.ToInt32(kernelTextBox.Text);

            if (originalImage == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            if (!int.TryParse(kernelTextBox.Text, out kernelSize))
            {
                MessageBox.Show("Please enter a valid kernel size for opening.");
                return;
            }

            processedImage = MorfolojikIslemler.Opening(originalImage, kernelSize);
            pictureBoxResult.Image = processedImage;
        }

        private void KapamaButton_Click(object sender, EventArgs e)
        {
            int kernelSize = Convert.ToInt32(kernelTextBox.Text);

            if (originalImage == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            if (!int.TryParse(kernelTextBox.Text, out kernelSize))
            {
                MessageBox.Show("Please enter a valid kernel size for closing.");
                return;
            }

            processedImage = MorfolojikIslemler.Closing(originalImage, kernelSize);
            pictureBoxResult.Image = processedImage;
        }

        private void MorphologicalOperationsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
