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
    public partial class ColorSpaceTransformationsForm : Form
    {
        private Bitmap originalImage;
        public ColorSpaceTransformationsForm()
        {
            InitializeComponent();
        }

        private void resimEkleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp|Tüm Dosyalar|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                pictureBoxOriginal.Image = originalImage;
            }
        }

        private void RGBtoNTSCButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxOriginal.Image);
            Bitmap ntscBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    double r = pixel.R / 255.0;
                    double g = pixel.G / 255.0;
                    double b = pixel.B / 255.0;

                    double yComponent = 0.299 * r + 0.587 * g + 0.114 * b;
                    double iComponent = 0.596 * r - 0.274 * g - 0.322 * b;
                    double qComponent = 0.211 * r - 0.523 * g + 0.312 * b;

                    int yValue = (int)(yComponent * 255);
                    int iValue = (int)((iComponent + 0.5957) * 255 / 1.5957);
                    int qValue = (int)((qComponent + 0.5226) * 255 / 1.5226);

                    ntscBmp.SetPixel(x, y, Color.FromArgb(yValue, iValue, qValue));
                }
            }

            pictureBoxTransformed.Image = ntscBmp;
        }

        private void RGBtoYCbCrButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxOriginal.Image);
            Bitmap ycbcrBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    double r = pixel.R;
                    double g = pixel.G;
                    double b = pixel.B;

                    double yComponent = 0.299 * r + 0.587 * g + 0.114 * b;
                    double cbComponent = 128 - 0.168736 * r - 0.331264 * g + 0.5 * b;
                    double crComponent = 128 + 0.5 * r - 0.418688 * g - 0.081312 * b;

                    int yValue = (int)yComponent;
                    int cbValue = (int)cbComponent;
                    int crValue = (int)crComponent;

                    ycbcrBmp.SetPixel(x, y, Color.FromArgb(yValue, cbValue, crValue));
                }
            }

            pictureBoxTransformed.Image = ycbcrBmp;
        }

        private void RGBtoCMYButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxOriginal.Image);
            Bitmap cmyBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    int c = 255 - pixel.R;
                    int m = 255 - pixel.G;
                    int yValue = 255 - pixel.B;

                    cmyBmp.SetPixel(x, y, Color.FromArgb(c, m, yValue));
                }
            }

            pictureBoxTransformed.Image = cmyBmp;
        }

        private void RGBtoCMYKButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxOriginal.Image);
            Bitmap cmykBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    double r = pixel.R / 255.0;
                    double g = pixel.G / 255.0;
                    double b = pixel.B / 255.0;

                    double k = 1 - Math.Max(r, Math.Max(g, b));
                    double c = (1 - r - k) / (1 - k);
                    double m = (1 - g - k) / (1 - k);
                    double yValue = (1 - b - k) / (1 - k);

                    int cValue = (int)(c * 255);
                    int mValue = (int)(m * 255);
                    int yIntValue = (int)(yValue * 255);
                    int kValue = (int)(k * 255);

                    cmykBmp.SetPixel(x, y, Color.FromArgb(cValue, mValue, yIntValue, kValue));
                }
            }

            pictureBoxTransformed.Image = cmykBmp;
        }

        private void RGBtoHSIButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxOriginal.Image);
            Bitmap hsiBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    double r = pixel.R / 255.0;
                    double g = pixel.G / 255.0;
                    double b = pixel.B / 255.0;

                    double intensity = (r + g + b) / 3.0;

                    double minValue = Math.Min(r, Math.Min(g, b));
                    double saturation = 1 - (minValue / intensity);

                    double hue = 0;
                    if (saturation != 0)
                    {
                        double num = 0.5 * ((r - g) + (r - b));
                        double den = Math.Sqrt((r - g) * (r - g) + (r - b) * (g - b));
                        double theta = Math.Acos(num / den);

                        if (b <= g)
                            hue = theta;
                        else
                            hue = 2 * Math.PI - theta;
                    }

                    hue = hue * 180 / Math.PI; // Convert to degrees
                    int hValue = (int)(hue / 360 * 255); // Scale to 0-255
                    int sValue = (int)(saturation * 255); // Scale to 0-255
                    int iValue = (int)(intensity * 255); // Scale to 0-255

                    hsiBmp.SetPixel(x, y, Color.FromArgb(hValue, sValue, iValue));
                }
            }

            pictureBoxTransformed.Image = hsiBmp;
        }

        private void ColorSpaceTransformationsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
