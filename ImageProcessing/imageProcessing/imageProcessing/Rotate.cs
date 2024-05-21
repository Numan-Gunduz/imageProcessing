using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class Rotate
    {
        public static Bitmap RotateImage(Bitmap originalImage, float angle)
        {
            // Dereceyi radyana çevir
            float radianAngle = angle * ((float)Math.PI / 180);

            // Yeni döndürülmüş resim boyutlarını hesapla
            int newWidth = (int)(Math.Abs(originalImage.Width * Math.Cos(radianAngle)) + Math.Abs(originalImage.Height * Math.Sin(radianAngle)));
            int newHeight = (int)(Math.Abs(originalImage.Width * Math.Sin(radianAngle)) + Math.Abs(originalImage.Height * Math.Cos(radianAngle)));

            Bitmap rotatedImage = new Bitmap(newWidth, newHeight);
            Graphics g = Graphics.FromImage(rotatedImage);

            // Döndürülmüş resmi çiz
            g.TranslateTransform((float)newWidth / 2, (float)newHeight / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)originalImage.Width / 2, -(float)originalImage.Height / 2);
            g.DrawImage(originalImage, new Point(0, 0));

            return rotatedImage;
        }
    }
}
