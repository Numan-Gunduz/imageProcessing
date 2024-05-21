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

        private void selectImageButton_Click(object sender, EventArgs e)
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
                pictureBox.Image = originalImage; // Orijinal resmi ilk PictureBox'a yükle
                pictureBox1.Image = grayscaleImage; // Gri dönüşümü yapmış resmi ikinci PictureBox'a yükle
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
                pictureBox.Image = originalImage; // Orijinal resmi ilk PictureBox'a yükle
                pictureBox1.Image = binaryImage;
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
                pictureBox.Image = originalImage; // Orijinal resmi ilk PictureBox'a yükle
                pictureBox1.Image = rotatedImage;
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
                pictureBox.Image = originalImage; // Orijinal resmi ilk PictureBox'a yükle
                pictureBox1.Image = croppedImage;
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
                double zoomFactor = 0.25; // Uzaklaştırma faktörü, istediğiniz değeri kullanabilirsiniz

                // Uzaklaştırılmış resmi oluştur
                Bitmap zoomedImage = ZoomOut.ZoomOutImage(originalImage, zoomFactor);

                // Uzaklaştırılmış resmi pictureBox1'de göster
                pictureBox1.Image = zoomedImage;

                // İşlenmemiş resmi pictureBox'da göstermek için PictureBox1'in boyutunu pictureBox'a uygun şekilde ayarla
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Zoom işlemi yapıldığı için pictureBox1'in resmi görüntüleme alanını ayarlayın
                pictureBox1.ClientSize = new Size(originalImage.Width / 4, originalImage.Height / 4);

                // İşlenmemiş resmi pictureBox'da göster
                pictureBox.Image = originalImage;
            }
            else
            {
                MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void ParlaklıkArttırButton_Click(object sender, EventArgs e)
        {
            int parlaklikMiktari;

            if (int.TryParse(parlaklikTextBox.Text, out parlaklikMiktari))
            {
                Bitmap parlakResim = Parlaklık.Arttır(originalImage, parlaklikMiktari);
                pictureBox.Image = originalImage; // Orijinal resmi ilk PictureBox'a yükle
                pictureBox1.Image = parlakResim;
            }
            else
            {
                MessageBox.Show("Geçerli bir parlaklık miktarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AdaptifEşiklemeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAcDialog = new OpenFileDialog();
            dosyaAcDialog.Filter = "Resim Dosyaları (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            if (dosyaAcDialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dosyaAcDialog.FileName;
                Bitmap orijinalResim = new Bitmap(dosyaYolu);

                Bitmap adaptifEşiklemeResim = AdaptifEşikleme.Uygula(orijinalResim, 15); // Pencere boyutunu burada belirleyebilirsiniz
                pictureBox.Image = originalImage; // Orijinal resmi ilk PictureBox'a yükle
                pictureBox1.Image = adaptifEşiklemeResim;
            }
        }


        private async void sobelButton_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                MessageBox.Show("Kenar bulma işlemi başlıyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                await Task.Run(() =>
                {
                    Bitmap sobelImage = SobelKenarBulucu.SobelKenarBul(originalImage);

                    pictureBox.Invoke(new Action(() =>
                    {
                        pictureBox.Image = originalImage; // Orijinal resmi ilk PictureBox'a yükle
                        pictureBox1.Image = sobelImage; // Sonucu PictureBox üzerinde gösterin
                        MessageBox.Show("Kenar bulma işlemi tamamlandı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }));
                });
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
                int kernelSize = 5; // Örnek olarak bir kernel boyutu belirleyin, istediğiniz değeri kullanabilirsiniz
                double sigma = 3.0; // Örnek olarak bir sigma değeri belirleyin, istediğiniz değeri kullanabilirsiniz

                Bitmap gaussImage = GaussDonustur.GaussFiltre(originalImage, kernelSize, sigma);

                pictureBox.Image = originalImage; // Orijinal resmi ilk PictureBox'a yükle
                pictureBox1.Image = gaussImage;  // Sonucu PictureBox üzerinde gösterin
                MessageBox.Show("buraya kadar doğru bitiyor .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void blurButton_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                int blurAmount;
                if (int.TryParse(blurAmountTextBox.Text, out blurAmount))
                {
                    Bitmap blurredImage = Blur.ApplyBlur(originalImage, blurAmount);
                    pictureBox.Image = originalImage; // Orijinal resmi ilk PictureBox'a yükle
                    pictureBox1.Image = blurredImage;
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir bulanıklık miktarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaltAndPepper_Click(object sender, EventArgs e)
        {
            // Salt ve biber formunu oluşturun
            SaltPepperForm saltPepperForm = new SaltPepperForm();

            // Ana formun üstüne gelen modal olarak salt ve biber formunu gösterin
            saltPepperForm.ShowDialog();
        }

        private void AritmetikIslemlerButton_Click(object sender, EventArgs e)
        {
            ArithmeticOperationsForm arithmeticOperationsForm = new ArithmeticOperationsForm();
            arithmeticOperationsForm.ShowDialog();
        }

        private void MorfolojikIslemlerButton_Click(object sender, EventArgs e)
        {
            MorphologicalOperationsForm morphologicalOperationsForm = new MorphologicalOperationsForm();
            morphologicalOperationsForm.ShowDialog();
        }

        private void renkUzayıButton_Click(object sender, EventArgs e)
        {
            ColorSpaceTransformationsForm colorSpaceTransformationsForm = new ColorSpaceTransformationsForm();
            colorSpaceTransformationsForm.ShowDialog();
        }

        private void HistogramButton_Click(object sender, EventArgs e)
        {
            HistogramForm histogramForm = new HistogramForm();
            histogramForm.ShowDialog();
        }

        private void angleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void blurAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void scaleYTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void f_Enter(object sender, EventArgs e)
        {

        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                double zoomFactor = 4; // Yakınlaştırma faktörü, istediğiniz değeri kullanabilirsiniz

                // Yakınlaştırılmış resmi oluştur
                Bitmap zoomedImage = ZoomIn.ZoomInImage(originalImage, zoomFactor);

                // Yakınlaştırılmış resmi pictureBox1'de göster
                pictureBox1.Image = zoomedImage;

                // İşlenmemiş resmi pictureBox'da göstermek için PictureBox1'in boyutunu pictureBox'a uygun şekilde ayarla
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Zoom işlemi yapıldığı için pictureBox1'in resmi görüntüleme alanını ayarlayın
                pictureBox1.ClientSize = new Size(originalImage.Width * 4, originalImage.Height * 4);

                // İşlenmemiş resmi pictureBox'da göster
                pictureBox.Image = originalImage;
            }
            else
            {
                MessageBox.Show("Önce bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
       
    }
}

