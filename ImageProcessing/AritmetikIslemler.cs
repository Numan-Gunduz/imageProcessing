using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    internal class AritmetikIslemler
    {
        public static Bitmap AddImages(Bitmap firstImage, Bitmap secondImage)
        {
            if (firstImage.Size != secondImage.Size)
            {
                throw new ArgumentException("Images must have the same dimensions.");
            }

            int width = firstImage.Width;
            int height = firstImage.Height;
            Bitmap resultImage = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color firstPixel = firstImage.GetPixel(x, y);
                    Color secondPixel = secondImage.GetPixel(x, y);

                    int newRed = Math.Min(firstPixel.R + secondPixel.R, 255);
                    int newGreen = Math.Min(firstPixel.G + secondPixel.G, 255);
                    int newBlue = Math.Min(firstPixel.B + secondPixel.B, 255);

                    Color newPixel = Color.FromArgb(newRed, newGreen, newBlue);
                    resultImage.SetPixel(x, y, newPixel);
                }
            }

            return resultImage;
        }

        public static Bitmap MultiplyImages(Bitmap firstImage, Bitmap secondImage)
        {
            if (firstImage.Size != secondImage.Size)
            {
                throw new ArgumentException("Images must have the same dimensions.");
            }

            int width = firstImage.Width;
            int height = firstImage.Height;
            Bitmap resultImage = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color firstPixel = firstImage.GetPixel(x, y);
                    Color secondPixel = secondImage.GetPixel(x, y);

                    int newRed = (int)((firstPixel.R / 255.0) * (secondPixel.R / 255.0) * 255);
                    int newGreen = (int)((firstPixel.G / 255.0) * (secondPixel.G / 255.0) * 255);
                    int newBlue = (int)((firstPixel.B / 255.0) * (secondPixel.B / 255.0) * 255);

                    Color newPixel = Color.FromArgb(newRed, newGreen, newBlue);
                    resultImage.SetPixel(x, y, newPixel);
                }
            }

            return resultImage;
        }
    }
}
