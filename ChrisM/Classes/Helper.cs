using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisM.Classes
{
    public static class Helper
    {
        public static Image ChangeImageColor(Image image, Color baseColor, Color targetColor)
        {
            Bitmap bitmap = (Bitmap)image;

            for(int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    if(bitmap.GetPixel(x,y).ToArgb() == baseColor.ToArgb())
                    {
                        bitmap.SetPixel(x,y,targetColor);
                    }
                }
            }

            return (Image)bitmap;
        }
    }
}
