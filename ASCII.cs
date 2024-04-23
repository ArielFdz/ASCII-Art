using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Art
{
    internal class ASCII
    {
        private static string[] _ascciChars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", " " };

        public static string ASCIIGenerator(Bitmap image)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color pixelColor = image.GetPixel(j, i);
                    int grayValue = CalculateGrayValue(pixelColor);
                    int index = (grayValue * 10) / 255;
                    sb.Append(_ascciChars[index]);
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private static int CalculateGrayValue(Color color)
        {
            return (int)(0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B);
        }
    }
}
