using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGate.Utils
{
    public static class Color
    {
        public static string HexColorCodeToConvertInverter(string val)
        {
            string returned = val.TrimStart('#');
            int colorValue = Convert.ToInt32(returned, 16);
            int invertedColorValue = 0xFFFFFF - colorValue;
            string invertedHexColor = "#" + invertedColorValue.ToString("X6");
            return invertedHexColor;
        }

        public static string HexColorToFaded(string val) {
            System.Drawing.Color originalColor = ColorTranslator.FromHtml(val);
            float fadeFactor = 0.5f;
            int newR = (int)(originalColor.R * (1 - fadeFactor));
            int newG = (int)(originalColor.G * (1 - fadeFactor));
            int newB = (int)(originalColor.B * (1 - fadeFactor));
            System.Drawing.Color fadedColor = System.Drawing.Color.FromArgb(newR, newG, newB);
            string fadedHexColor = ColorTranslator.ToHtml(fadedColor);
            return fadedHexColor;
        }
    }
}
