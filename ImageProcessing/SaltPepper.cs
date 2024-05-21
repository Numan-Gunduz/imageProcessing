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
    public partial class SaltPepperForm : Form
    {
        private Bitmap originalImage; // Orjinal resmi tutmak için alan
        private double saltProbability = 0.05; // Varsayılan salt gürültü olasılığı
        private double pepperProbability = 0.05; // Varsayılan biber gürültü olasılığı

        public SaltPepperForm()
        {
            InitializeComponent();
        }
        private void resimSecButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.png; *.gif)|*.bmp;*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;

                // Seçilen resmi yükleyin ve PictureBox üzerinde gösterin
                Bitmap resim = new Bitmap(dosyaYolu);
                originalPictureBox.Image = resim;

                // originalImage değişkenine seçilen resmi atayın
                originalImage = resim;
            }
        }

        private void saltPepperButton_Click_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Salt ve biber gürültüsü ekleyerek işlem görmüş resmi oluşturun
            Bitmap processedImage = SaltAndPepperNoise.AddSaltAndPepperNoise(originalImage, saltProbability, pepperProbability);

            // PictureBox'a işlem görmüş resmi yükleyin
            processedPictureBox.Image = processedImage; 

        }
        private void saltPepperButton_Click(object sender, EventArgs e)
        {
            saltPepperButton_Click_Click(sender, e);
        }

       

        private void saltTrackBar_Scroll(object sender, EventArgs e)
        {
            saltProbability = (double)saltTrackBar.Value / 100.0;
            saltLabel.Text = "Salt Olasılığı: " + saltProbability.ToString("P0");
        }

        private void pepperTrackBar_Scroll(object sender, EventArgs e)
        {
            pepperProbability = (double)pepperTrackBar.Value / 100.0;
            pepperLabel.Text = "Pepper Olasılığı: " + pepperProbability.ToString("P0");
        }

        private void meanFilterButton_Click(object sender, EventArgs e)
        {
            if (processedPictureBox.Image == null)
            {
                MessageBox.Show("Lütfen önce bir işlem görmüş resim oluşturun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap noisyImage = new Bitmap(processedPictureBox.Image);
            Bitmap medianFilteredImage = Filters.ApplyMedianFilter(noisyImage, 3);
            meanPictureBox.Image = medianFilteredImage;
        }

        private void medianFilterButton_Click(object sender, EventArgs e)
        {
            if (processedPictureBox.Image == null)
            {
                MessageBox.Show("Lütfen önce bir işlem görmüş resim oluşturun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap noisyImage = new Bitmap(processedPictureBox.Image);
            Bitmap medianFilteredImage = Filters.ApplyMedianFilter(noisyImage, 3);
            medianPictureBox.Image = medianFilteredImage;
        }

        private void SaltPepperForm_Load(object sender, EventArgs e)
        {

        }
    }
}
