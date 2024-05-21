using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class BinaryDonustur
    {
        public static Bitmap BinaryyeDonustur(Bitmap originalImage, int esikDegeri)
        {
            Bitmap binaryImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixel = originalImage.GetPixel(x, y);
                    int griDeger = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    if (griDeger >= esikDegeri)
                    {
                        binaryImage.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        binaryImage.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return binaryImage;
        }
    }
}
