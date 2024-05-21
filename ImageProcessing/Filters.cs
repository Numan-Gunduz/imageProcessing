using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class Filters
    {
        public static Bitmap ApplyMeanFilter(Bitmap image, int kernelSize)
        {
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);
            int offset = kernelSize / 2;

            for (int y = offset; y < image.Height - offset; y++)
            {
                for (int x = offset; x < image.Width - offset; x++)
                {
                    int rSum = 0;
                    int gSum = 0;
                    int bSum = 0;
                    int count = 0;

                    for (int ky = -offset; ky <= offset; ky++)
                    {
                        for (int kx = -offset; kx <= offset; kx++)
                        {
                            int pixelX = x + kx;
                            int pixelY = y + ky;

                            if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                            {
                                Color pixel = image.GetPixel(pixelX, pixelY);
                                rSum += pixel.R;
                                gSum += pixel.G;
                                bSum += pixel.B;
                                count++;
                            }
                        }
                    }

                    int rMean = rSum / count;
                    int gMean = gSum / count;
                    int bMean = bSum / count;

                    filteredImage.SetPixel(x, y, Color.FromArgb(rMean, gMean, bMean));
                }
            }

            return filteredImage;
        }

        public static Bitmap ApplyMedianFilter(Bitmap image, int kernelSize)
        {
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);
            int offset = kernelSize / 2;

            for (int y = offset; y < image.Height - offset; y++)
            {
                for (int x = offset; x < image.Width - offset; x++)
                {
                    List<int> rValues = new List<int>();
                    List<int> gValues = new List<int>();
                    List<int> bValues = new List<int>();

                    for (int ky = -offset; ky <= offset; ky++)
                    {
                        for (int kx = -offset; kx <= offset; kx++)
                        {
                            Color pixel = image.GetPixel(x + kx, y + ky);
                            rValues.Add(pixel.R);
                            gValues.Add(pixel.G);
                            bValues.Add(pixel.B);
                        }
                    }

                    rValues.Sort();
                    gValues.Sort();
                    bValues.Sort();

                    int rMedian = rValues[rValues.Count / 2];
                    int gMedian = gValues[gValues.Count / 2];
                    int bMedian = bValues[bValues.Count / 2];

                    filteredImage.SetPixel(x, y, Color.FromArgb(rMedian, gMedian, bMedian));
                }
            }

            return filteredImage;
        }
    }
}
