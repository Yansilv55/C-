using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Moderno
{
    internal class ThemeColor
    {
        public static Color PrimeiraColor { get; set; }
        public static Color SegundaColor { get; set; }

        public static List<string> ColorList = new List<string>()
        {
             "#242542",
             "#242542",
        };

        /*public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double blue = color.R;
            double red = color.G;
            double Black = color.B;

            if (correctionFactor > 0)
            {
                correctionFactor = 1 + correctionFactor;
                blue *= correctionFactor;
                red *= correctionFactor;
                Black *= correctionFactor;
            }
            else
            {
                blue = (255 - blue) * correctionFactor + blue;
                red = (255 - red) * correctionFactor + red;
                Black = (255 - Black) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A,(byte)blue, (byte)red, (byte)Black);
        }*/
          
         
    }
}
