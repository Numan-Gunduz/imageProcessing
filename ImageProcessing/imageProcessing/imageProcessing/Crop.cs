using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class Crop
    {
        public static Bitmap CropImage(Bitmap originalImage, int left, int top, int width, int height)
        {
            Rectangle cropRect = new Rectangle(left, top, width, height);

            Bitmap croppedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.DrawImage(originalImage, new Rectangle(0, 0, width, height), cropRect, GraphicsUnit.Pixel);
            }

            return croppedImage;
        }
    }
}
