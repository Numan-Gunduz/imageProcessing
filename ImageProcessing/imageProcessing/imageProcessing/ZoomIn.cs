using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class ZoomIn
    {
        public static Bitmap ZoomInImage(Bitmap originalImage, float scaleFactor)
        {
            // Orijinal resmin boyutlarını al
            int originalWidth = originalImage.Width;
            int originalHeight = originalImage.Height;

            // Yeni boyutları hesapla
            int newWidth = (int)(originalWidth * scaleFactor);
            int newHeight = (int)(originalHeight * scaleFactor);

            // Yeni boyutlar geçerli mi kontrol et
            if (newWidth <= 0 || newHeight <= 0)
            {
                throw new ArgumentException("Geçersiz boyutlar: Yeni boyutlar sıfırdan küçük olamaz.");
            }


            // Yeni boyutlar için bir Bitmap nesnesi oluştur
            Bitmap zoomInImage = new Bitmap(newWidth, newHeight);

            // Yeni boyutları elde etmek için Graphics nesnesi kullan
            using (Graphics g = Graphics.FromImage(zoomInImage))
            {
                // İnterpolasyon modunu ayarla
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Orijinal resmi yeni boyutlara uygun olarak çiz
                g.DrawImage(originalImage, new Rectangle(0, 0, newWidth, newHeight),
                            new Rectangle(0, 0, originalWidth, originalHeight), GraphicsUnit.Pixel);
            }

            // Büyütülmüş resmi döndür
            return zoomInImage;
        }
    }
}
