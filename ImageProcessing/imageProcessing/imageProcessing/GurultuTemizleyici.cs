using System;
using System.Drawing;
//using static System.Net.Mime.MediaTypeNames;

namespace imageProcessing
{
	public class GurultuTemizleyici
	{
		public static Bitmap MeanFiltre(Bitmap originalImage)
		{
			Bitmap filteredImage = new Bitmap(originalImage.Width, originalImage.Height);
			for (int y = 1; y < originalImage.Height - 1; y++)
			{
				for (int x = 1; x < originalImage.Width - 1; x++)
				{
					int totalR = 0, totalG = 0, totalB = 0;

					for (int j = -1; j <= 1; j++)
					{
						for (int i = -1; i <= 1; i++)
						{
							Color pixelColor = originalImage.GetPixel(x + i, y + j);
							totalR += pixelColor.R;
							totalG += pixelColor.G;
							totalB += pixelColor.B;
						}
					}

					int avgR = totalR / 9;
					int avgG = totalG / 9;
					int avgB = totalB / 9;

					Color newColor = Color.FromArgb(avgR, avgG, avgB);
					filteredImage.SetPixel(x, y, newColor);
				}
			}

			return filteredImage;

		}


		public static Bitmap MedianFiltre(Bitmap originalImage, int kernelSize)
		{
			Bitmap filteredImage = new Bitmap(originalImage.Width, originalImage.Height);

			for (int y = 0; y < originalImage.Height; y++)
			{
				for (int x = 0; x < originalImage.Width; x++)
				{
					int[] redValues = new int[kernelSize * kernelSize];
					int[] greenValues = new int[kernelSize * kernelSize];
					int[] blueValues = new int[kernelSize * kernelSize];
					int index = 0;

					for (int j = -kernelSize / 2; j <= kernelSize / 2; j++)
					{
						for (int i = -kernelSize / 2; i <= kernelSize / 2; i++)
						{
							int pixelX = Math.Min(Math.Max(x + i, 0), originalImage.Width - 1);
							int pixelY = Math.Min(Math.Max(y + j, 0), originalImage.Height - 1);

							Color pixel = originalImage.GetPixel(pixelX, pixelY);
							redValues[index] = pixel.R;
							greenValues[index] = pixel.G;
							blueValues[index] = pixel.B;
							index++;
						}
					}

					// Dizileri sıralamadan önce boyutlarını kontrol et
					if (index == kernelSize * kernelSize)
					{
						Array.Sort(redValues);
						Array.Sort(greenValues);
						Array.Sort(blueValues);

						Color newPixel = Color.FromArgb(redValues[index / 2], greenValues[index / 2], blueValues[index / 2]);
						filteredImage.SetPixel(x, y, newPixel);
					}
					else
					{
						// Hata durumunda, orijinal pikseli kopyala
						Color originalPixel = originalImage.GetPixel(x, y);
						filteredImage.SetPixel(x, y, originalPixel);
					}
				}
			}

			return filteredImage;
		}


	}
}
