using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    internal class Histogram
    {
        public static Bitmap HistogramStretch(Bitmap bmp, int minGray, int maxGray)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap stretchedBmp = new Bitmap(width, height);

            // Histogram germe işlemi
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    int gray = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    int stretchedGray = (gray - minGray) * 255 / (maxGray - minGray);
                    stretchedGray = Math.Max(0, Math.Min(255, stretchedGray)); // Clamp to [0, 255]
                    stretchedBmp.SetPixel(x, y, Color.FromArgb(stretchedGray, stretchedGray, stretchedGray));
                }
            }
            return stretchedBmp;
        }

        // Histogram genişletme fonksiyonu
        public static Bitmap HistogramEqualize(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap equalizedBmp = new Bitmap(width, height);

            // Histogram hesapla
            int[] histogram = ComputeHistogram(bmp);
            int totalPixels = width * height;

            // Kumulatif histogram hesapla
            int[] cumulativeHistogram = new int[256];
            cumulativeHistogram[0] = histogram[0];
            for (int i = 1; i < 256; i++)
            {
                cumulativeHistogram[i] = cumulativeHistogram[i - 1] + histogram[i];
            }

            // Histogram genişletme işlemi
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    int gray = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    int equalizedGray = (int)(255.0 * cumulativeHistogram[gray] / totalPixels);
                    equalizedBmp.SetPixel(x, y, Color.FromArgb(equalizedGray, equalizedGray, equalizedGray));
                }
            }
            return equalizedBmp;
        }

        // Histogram hesaplama fonksiyonu
        private static int[] ComputeHistogram(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            int[] histogram = new int[256];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    int gray = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    histogram[gray]++;
                }
            }
            return histogram;
        }
    }
}
