using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageProcessing
{
    public class Parlaklık
    {
        public static Bitmap Arttır(Bitmap resim, int artışMiktarı)
        {
            Bitmap parlakResim = new Bitmap(resim.Width, resim.Height);

            for (int x = 0; x < resim.Width; x++)
            {
                for (int y = 0; y < resim.Height; y++)
                {
                    Color piksel = resim.GetPixel(x, y);
                    int yeniR = Math.Min(255, piksel.R + artışMiktarı);
                    int yeniG = Math.Min(255, piksel.G + artışMiktarı);
                    int yeniB = Math.Min(255, piksel.B + artışMiktarı);
                    Color yeniPiksel = Color.FromArgb(yeniR, yeniG, yeniB);
                    parlakResim.SetPixel(x, y, yeniPiksel);
                }
            }

            return parlakResim;
        }
    }
}
