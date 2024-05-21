using System;
using System.Drawing;

namespace imageProcessing
{
	public class GaussDonustur
	{
		public static Bitmap GaussFiltre(Bitmap originalImage, int kernelSize, double sigma)
		{
			Bitmap resultImage = new Bitmap(originalImage.Width, originalImage.Height);

			double[,] kernel = CalculateGaussianKernel(kernelSize, sigma);

			int radius = kernelSize / 2;

			for (int y = radius; y < originalImage.Height - radius; y++)
			{
				for (int x = radius; x < originalImage.Width - radius; x++)
				{
					double red = 0.0, green = 0.0, blue = 0.0;

					for (int filterY = -radius; filterY <= radius; filterY++)
					{
						for (int filterX = -radius; filterX <= radius; filterX++)
						{
							Color imageColor = originalImage.GetPixel(x + filterX, y + filterY);
							double filterValue = kernel[filterY + radius, filterX + radius];

							red += imageColor.R * filterValue;
							green += imageColor.G * filterValue;
							blue += imageColor.B * filterValue;
						}
					}

					red = Math.Min(Math.Max(red, 0), 255);
					green = Math.Min(Math.Max(green, 0), 255);
					blue = Math.Min(Math.Max(blue, 0), 255);

					Color newColor = Color.FromArgb((int)red, (int)green, (int)blue);
					resultImage.SetPixel(x, y, newColor);
				}
			}

			return resultImage;
		}

		private static double[,] CalculateGaussianKernel(int size, double sigma)
		{
			double[,] kernel = new double[size, size];
			double sumTotal = 0;

			int kernelRadius = size / 2;
			double calculatedEuler = 1.0 / (2.0 * Math.PI * sigma * sigma);

			for (int filterY = -kernelRadius; filterY <= kernelRadius; filterY++)
			{
				for (int filterX = -kernelRadius; filterX <= kernelRadius; filterX++)
				{
					double distance = (filterX * filterX + filterY * filterY) / (2 * (sigma * sigma));
					kernel[filterY + kernelRadius, filterX + kernelRadius] = calculatedEuler * Math.Exp(-distance);
					sumTotal += kernel[filterY + kernelRadius, filterX + kernelRadius];
				}
			}

			for (int y = 0; y < size; y++)
			{
				for (int x = 0; x < size; x++)
				{
					kernel[y, x] = kernel[y, x] * (1.0 / sumTotal);
				}
			}

			return kernel;
		}
	}
}
