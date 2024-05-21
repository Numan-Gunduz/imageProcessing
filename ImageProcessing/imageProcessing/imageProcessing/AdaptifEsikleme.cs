using System;
using System.Drawing;

namespace imageProcessing
{
	public class AdaptifEsikleme
	{
		public static Bitmap AdaptifEsikle(Bitmap originalImage, int blockSize, int C)
		{
			Bitmap resultImage = new Bitmap(originalImage.Width, originalImage.Height);

			// Görüntüyü tur atarak işleme
			for (int y = 0; y < originalImage.Height; y++)
			{
				for (int x = 0; x < originalImage.Width; x++)
				{
					int esikDegeri = CalculateLocalThreshold(originalImage, x, y, blockSize, C);
					Color pixel = originalImage.GetPixel(x, y);
					int griDeger = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
					if (griDeger >= esikDegeri)
					{
						resultImage.SetPixel(x, y, Color.White);
					}
					else
					{
						resultImage.SetPixel(x, y, Color.Black);
					}
				}
			}

			return resultImage;
		}

		private static int CalculateLocalThreshold(Bitmap originalImage, int x, int y, int blockSize, int C)
		{
			int sum = 0;
			int count = 0;

			int startX = Math.Max(0, x - (blockSize / 2));
			int endX = Math.Min(originalImage.Width - 1, x + (blockSize / 2));
			int startY = Math.Max(0, y - (blockSize / 2));
			int endY = Math.Min(originalImage.Height - 1, y + (blockSize / 2));

			// Blok içindeki gri değerlerinin ortalamasını al ve eşik değerini hesapla
			for (int j = startY; j <= endY; j++)
			{
				for (int i = startX; i <= endX; i++)
				{
					Color pixel = originalImage.GetPixel(i, j);
					int grayValue = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
					sum += grayValue;
					count++;
				}
			}

			if (count == 0)
			{
				return 0; // Hata durumunda 0 değeri döndürülebilir veya başka bir değer belirlenebilir.
			}

			int mean = sum / count;
			int threshold = mean + C;

			return threshold;
		}
	}
}
