using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace imageProcessing
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
		private void selectImageButton_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.png; *.gif)|*.bmp;*.jpg;*.png;*.gif";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				originalImage = new Bitmap(openFileDialog.FileName);
				pictureBox.Image = originalImage;
			}
		}

		private void grayscaleButton_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                Bitmap grayscaleImage = GriDonusum.GriyeDonustur(originalImage); // Gri dönüşüm işlemini GriDonusum sınıfındaki GriyeDonustur fonksiyonu ile gerçekleştirin
                pictureBox.Image = grayscaleImage; // Sonucu pictureBox üzerinde gösterin
            }
            else
            {
                MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                int esikDegeri = 128; // Örnek olarak bir eşik değeri belirleyin, istediğiniz değeri kullanabilirsiniz
                Bitmap binaryImage = BinaryDonustur.BinaryyeDonustur(originalImage, esikDegeri);
                pictureBox.Image = binaryImage; // Sonucu PictureBox üzerinde gösterin
            }
            else
            {
                MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            float angle;
            if (float.TryParse(angleTextBox.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out angle))
            {
                Bitmap rotatedImage = Rotate.RotateImage(originalImage, angle);
                pictureBox.Image = rotatedImage;
            }
            else
            {
                MessageBox.Show("Önce bir açı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cropButton_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                // Kullanıcının girdiği ölçüleri al
                int left = int.Parse(leftTextBox.Text);
                int top = int.Parse(topTextBox.Text);
                int width = int.Parse(widthTextBox.Text);
                int height = int.Parse(heightTextBox.Text);

                // Resmi kırp
                Bitmap croppedImage = Crop.CropImage(originalImage, left, top, width, height);
                pictureBox.Image = croppedImage; // Kırpılmış resmi PictureBox üzerinde göster
            }
            else
            {
                MessageBox.Show("Önce bir boyut seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                int newWidth, newHeight;
                if (int.TryParse(widthTextBox1.Text, out newWidth) && int.TryParse(heightTextBox1.Text, out newHeight))
                {
                    // Girişler doğru, işlemi gerçekleştir
                    Bitmap zoomOutImage = ZoomOut.ZoomOutImage(originalImage, newWidth, newHeight);
                    pictureBox.Image = zoomOutImage; // Küçültülmüş resmi PictureBox üzerinde göster
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                float scaleFactor;
                if (float.TryParse(scaleFactorTextBox.Text, out scaleFactor))
                {
                    // Giriş doğru, işlemi gerçekleştir
                    Bitmap zoomInImage = ZoomIn.ZoomInImage(originalImage, scaleFactor);
                    pictureBox.Image = zoomInImage; // Büyütülmüş resmi PictureBox üzerinde göster
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

		private void gaussButton_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                int kernelSize = 3; // Örnek olarak bir kernel boyutu belirleyin, istediğiniz değeri kullanabilirsiniz
                double sigma = 1.5; // Örnek olarak bir sigma değeri belirleyin, istediğiniz değeri kullanabilirsiniz

                Bitmap gaussImage = GaussDonustur.GaussFiltre(originalImage, kernelSize, sigma);

				pictureBox.Image = gaussImage; // Sonucu PictureBox üzerinde gösterin
				MessageBox.Show("buraya kadar doğru bitiyor .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else
            {
                MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
		}

		private async void adaptiveThresholdButton_Click_1(object sender, EventArgs e)
		{
			if (originalImage != null)
			{
				int blockSize = 21; // Örnek olarak bir blok boyutu belirleyin, istediğiniz değeri kullanabilirsiniz
				int C = 10; // Örnek olarak bir C değeri belirleyin, istediğiniz değeri kullanabilirsiniz

				MessageBox.Show("Başlıyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				try
				{
					MessageBox.Show("Arka planda çalışma başlıyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					Bitmap adaptiveThresholdImage = await Task.Run(() =>
					{
						return AdaptifEsikleme.AdaptifEsikle(originalImage, blockSize, C);
					});

					MessageBox.Show("Arka planda çalışma tamamlandı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					pictureBox.Image = adaptiveThresholdImage; // Sonucu PictureBox üzerinde gösterin

					MessageBox.Show("Bitti", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private async  void sobelButton_Click(object sender, EventArgs e)
		{
			if (originalImage != null)
			{
				MessageBox.Show("Kenar bulma işlemi başlıyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				await Task.Run(() =>
				{
					Bitmap sobelImage = SobelKenarBulucu.SobelKenarBul(originalImage);

					pictureBox.Invoke(new Action(() =>
					{
						pictureBox.Image = sobelImage; // Sonucu PictureBox üzerinde gösterin
						MessageBox.Show("Kenar bulma işlemi tamamlandı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}));
				});
			}
			else
			{
				MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private readonly double defaultNoiseProbability = 0.05; // Varsayılan gürültü olasılığı (%5)
		private readonly int defaultKernelSize = 3; // Varsayılan çekirdek boyutu (3x3)
		private void noiseAddButton_Click(object sender, EventArgs e)
		{
			if(originalImage != null)

			{
				double noiseProbability = 0.1 ; // Varsayılan gürültü olasılığı (%5)

				// Gürültü ekleme işlemini gerçekleştir
				Bitmap noisyImage = SaltAndPepperGurultu.SaltAndPepperEkle(originalImage, noiseProbability);

				// PictureBox üzerinde gürültülü görüntüyü göster
				pictureBox.Image = noisyImage;
			}

			else
			{
				MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void meanFilterButton_Click(object sender, EventArgs e)
		{
			if (pictureBox.Image != null)
			{
				int kernelSize = 3; // Varsayılan çekirdek boyutu (3x3)

				// Temizleme işlemini gerçekleştir (Mean filtresi ile)
				MessageBox.Show("temizleme işlemi kontrol.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Bitmap cleanedImage = GurultuTemizleyici.MeanFiltre(new Bitmap(pictureBox.Image));
				MessageBox.Show("temizleme işlemi kontrol bitiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				// PictureBox üzerinde temizlenmiş görüntüyü göster
				pictureBox.Image = cleanedImage;
			}
			else
			{
				MessageBox.Show("Önce bir resim seçin veya gürültü ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		private void medianFilterButton_Click(object sender, EventArgs e)
		{

			if (pictureBox.Image != null)
			{

				int kernelSize = 3; // Varsayılan çekirdek boyutu (3x3)

				// Temizleme işlemini gerçekleştir (Median filtresi ile)
				Bitmap cleanedImage = GurultuTemizleyici.MedianFiltre(new Bitmap(pictureBox.Image), kernelSize);

				// PictureBox üzerinde temizlenmiş görüntüyü göster
				pictureBox.Image = cleanedImage;
			}
			else
			{

			}
			{
				MessageBox.Show("Önce bir resim seçin veya gürültü ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

	}
}
