using System;
using System.Drawing;

namespace imageProcessing
{
	public class SaltAndPepperGurultu
	{
		public static Bitmap SaltAndPepperEkle(Bitmap originalImage, double noiseProbability)
		{
			Bitmap noisyImage = new Bitmap(originalImage.Width, originalImage.Height);

			Random random = new Random();

			for (int y = 0; y < originalImage.Height; y++)
			{
				for (int x = 0; x < originalImage.Width; x++)
				{
					Color pixel = originalImage.GetPixel(x, y);
					if (random.NextDouble() < noiseProbability / 2)
					{
						noisyImage.SetPixel(x, y, Color.Black); // Salt noise
					}
					else if (random.NextDouble() < noiseProbability)
					{
						noisyImage.SetPixel(x, y, Color.White); // Pepper noise
					}
					else
					{
						noisyImage.SetPixel(x, y, pixel); // Original pixel
					}
				}
			}

			return noisyImage;
		}
	}
}
