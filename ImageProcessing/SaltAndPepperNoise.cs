using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class SaltAndPepperNoise
    {
        private static Random random = new Random();

        private double saltProbability = 0.5;
        private double pepperProbability = 0.5;

        public SaltAndPepperNoise(double saltProbability = 0.05, double pepperProbability = 0.05)
        {
            this.saltProbability = saltProbability;
            this.pepperProbability = pepperProbability;
        }

        public static Bitmap AddSaltAndPepperNoise(Bitmap originalImage, double saltProbability, double pepperProbability)
        {
            Bitmap noisyImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);

                    // Rastgele bir sayı oluşturarak salt veya pepper gürültüsü ekleyin
                    double randomValue = random.NextDouble();
                    if (randomValue < saltProbability)
                    {
                        // Salt gürültüsü ekle
                        noisyImage.SetPixel(x, y, Color.White);
                    }
                    else if (randomValue > 1 - pepperProbability)
                    {
                        // Pepper gürültüsü ekle
                        noisyImage.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        // Orijinal pikseli kullan
                        noisyImage.SetPixel(x, y, originalColor);
                    }
                }
            }

            return noisyImage;
        }
    }
}
