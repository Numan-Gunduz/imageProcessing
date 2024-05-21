using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    internal class MorfolojikIslemler
    {
        public static Bitmap Dilate(Bitmap originalImage, int kernelSize)
        {
            int width = originalImage.Width;
            int height = originalImage.Height;
            Bitmap resultImage = new Bitmap(width, height);

            // Genişleme işlemini uygula
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color maxColor = Color.Black;
                    for (int i = -kernelSize / 2; i <= kernelSize / 2; i++)
                    {
                        for (int j = -kernelSize / 2; j <= kernelSize / 2; j++)
                        {
                            int pixelX = x + i;
                            int pixelY = y + j;
                            if (pixelX >= 0 && pixelX < width && pixelY >= 0 && pixelY < height)
                            {
                                Color pixel = originalImage.GetPixel(pixelX, pixelY);
                                if (pixel.GetBrightness() > maxColor.GetBrightness())
                                {
                                    maxColor = pixel;
                                }
                            }
                        }
                    }
                    resultImage.SetPixel(x, y, maxColor);
                }
            }

            return resultImage;
        }

        public static Bitmap Erode(Bitmap originalImage, int kernelSize)
        {
            int width = originalImage.Width;
            int height = originalImage.Height;
            Bitmap resultImage = new Bitmap(width, height);

            // Aşınma işlemini uygula
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color minColor = Color.White;
                    for (int i = -kernelSize / 2; i <= kernelSize / 2; i++)
                    {
                        for (int j = -kernelSize / 2; j <= kernelSize / 2; j++)
                        {
                            int pixelX = x + i;
                            int pixelY = y + j;
                            if (pixelX >= 0 && pixelX < width && pixelY >= 0 && pixelY < height)
                            {
                                Color pixel = originalImage.GetPixel(pixelX, pixelY);
                                if (pixel.GetBrightness() < minColor.GetBrightness())
                                {
                                    minColor = pixel;
                                }
                            }
                        }
                    }
                    resultImage.SetPixel(x, y, minColor);
                }
            }

            return resultImage;
        }

        public static Bitmap Opening(Bitmap originalImage, int kernelSize)
        {
            // Açma işlemini uygula
            Bitmap resultImage = Erode(originalImage, kernelSize);
            resultImage = Dilate(resultImage, kernelSize);
            return resultImage;
        }

        public static Bitmap Closing(Bitmap originalImage, int kernelSize)
        {
            // Kapama işlemini uygula
            Bitmap resultImage = Dilate(originalImage, kernelSize);
            resultImage = Erode(resultImage, kernelSize);
            return resultImage;
        }
    }
}
