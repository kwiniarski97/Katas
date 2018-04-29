namespace Katas
{
    using System;

    public class RGB_To_Hex_Conversion
    {
        public static string Rgb(int r, int g, int b)
        {
            r = Math.Max(Math.Min(255, r), 0);
            g = Math.Max(Math.Min(255, g), 0);
            b = Math.Max(Math.Min(255, b), 0);
            return string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }
    }
}