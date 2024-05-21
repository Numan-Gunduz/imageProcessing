using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class AdaptifEşikleme
    {
        public static Bitmap Uygula(Bitmap resim, int pencereBoyutu)
        {
            Bitmap yeniResim = new Bitmap(resim.Width, resim.Height);

            for (int x = 0; x < resim.Width; x++)
            {
                for (int y = 0; y < resim.Height; y++)
                {
                    int eşik = HesaplaEşik(resim, x, y, pencereBoyutu);
                    Color piksel = resim.GetPixel(x, y);
                    int griTon = (piksel.R + piksel.G + piksel.B) / 3;
                    Color yeniPiksel = (griTon > eşik) ? Color.White : Color.Black;
                    yeniResim.SetPixel(x, y, yeniPiksel);
                }
            }

            return yeniResim;
        }

        private static int HesaplaEşik(Bitmap resim, int x, int y, int pencereBoyutu)
        {
            int toplam = 0;
            int pikselSayısı = 0;

            for (int i = x - pencereBoyutu / 2; i <= x + pencereBoyutu / 2; i++)
            {
                for (int j = y - pencereBoyutu / 2; j <= y + pencereBoyutu / 2; j++)
                {
                    if (i >= 0 && i < resim.Width && j >= 0 && j < resim.Height)
                    {
                        Color piksel = resim.GetPixel(i, j);
                        toplam += (piksel.R + piksel.G + piksel.B) / 3;
                        pikselSayısı++;
                    }
                }
            }

            return toplam / pikselSayısı;
        }
    }
}
