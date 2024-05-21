using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class Blur
    {
        public static Bitmap ApplyBlur(Bitmap originalImage, int blurAmount)
        {
            Bitmap blurredImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Blurring işlemini gerçekleştir
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    // Piksel değerlerini al
                    Color pixel = originalImage.GetPixel(x, y);
                    int avgR = 0, avgG = 0, avgB = 0;
                    int count = 0;

                    // Pikselin etrafındaki piksellerin ortalamasını alarak blurring efekti oluştur
                    for (int offsetY = -blurAmount; offsetY <= blurAmount; offsetY++)
                    {
                        for (int offsetX = -blurAmount; offsetX <= blurAmount; offsetX++)
                        {
                            int newX = Math.Max(0, Math.Min(x + offsetX, originalImage.Width - 1));
                            int newY = Math.Max(0, Math.Min(y + offsetY, originalImage.Height - 1));
                            Color neighborPixel = originalImage.GetPixel(newX, newY);
                            avgR += neighborPixel.R;
                            avgG += neighborPixel.G;
                            avgB += neighborPixel.B;
                            count++;
                        }
                    }

                    avgR /= count;
                    avgG /= count;
                    avgB /= count;

                    // Yeniden oluşturulan pikseli bulanık görüntüye ekle
                    Color blurredPixel = Color.FromArgb(avgR, avgG, avgB);
                    blurredImage.SetPixel(x, y, blurredPixel);
                }
            }

            return blurredImage;
        }
    }
}
