using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class GriDonusum
    {
        public static Bitmap GriyeDonustur(Bitmap originalImage)
        {
            Bitmap griImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixel = originalImage.GetPixel(x, y);
                    int griDeger = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    Color griRenk = Color.FromArgb(griDeger, griDeger, griDeger);
                    griImage.SetPixel(x, y, griRenk);
                }
            }

            return griImage;
        }
    }
}
