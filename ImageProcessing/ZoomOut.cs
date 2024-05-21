using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public static class ZoomOut
    {
        public static Bitmap ZoomOutImage(Bitmap originalImage, double zoomFactor)
        {
            int newWidth = (int)(originalImage.Width * zoomFactor);
            int newHeight = (int)(originalImage.Height * zoomFactor);

            Bitmap zoomOutImage = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(zoomOutImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return zoomOutImage;
        }
    }
}
