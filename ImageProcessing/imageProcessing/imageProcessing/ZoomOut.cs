using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class ZoomOut
    {
        public static Bitmap ZoomOutImage(Bitmap originalImage, int newWidth, int newHeight)
        {
            // Yeni boyutlar için bir Bitmap nesnesi oluştur
            Bitmap zoomOutImage = new Bitmap(newWidth, newHeight);

            // Yeni boyutları elde etmek için Graphics nesnesi kullan
            using (Graphics g = Graphics.FromImage(zoomOutImage))
            {
                // İnterpolasyon modunu ayarla
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Orijinal resmi yeni boyutlara uygun olarak çiz
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            // Küçültülmüş resmi döndür
            return zoomOutImage;
        }
    }
}
