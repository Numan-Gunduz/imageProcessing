using System;
using System.Drawing;

namespace imageProcessing
{
	public class SobelKenarBulucu
	{
		public static Bitmap SobelKenarBul(Bitmap originalImage)
		{
			Bitmap resultImage = new Bitmap(originalImage.Width, originalImage.Height);

			int[,] gx = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
			int[,] gy = new int[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

			for (int y = 1; y < originalImage.Height - 1; y++)
			{
				for (int x = 1; x < originalImage.Width - 1; x++)
				{
					int pixelX = 0;
					int pixelY = 0;

					for (int j = -1; j <= 1; j++)
					{
						for (int i = -1; i <= 1; i++)
						{
							Color pixel = originalImage.GetPixel(x + i, y + j);
							int grayValue = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
							pixelX += gx[j + 1, i + 1] * grayValue;
							pixelY += gy[j + 1, i + 1] * grayValue;
						}
					}

					int edgeColor = (int)Math.Sqrt(pixelX * pixelX + pixelY * pixelY);
					edgeColor = Math.Min(Math.Max(edgeColor, 0), 255); // Piksel değerini [0, 255] aralığına sıkıştır
					resultImage.SetPixel(x, y, Color.FromArgb(edgeColor, edgeColor, edgeColor));
				}
			}

			return resultImage;
		}
	}
}
