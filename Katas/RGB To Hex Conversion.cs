namespace Katas
{
    public class RGB_To_Hex_Conversion
    {
        public static string Rgb(int r, int g, int b)
        {
            return FormatInput(r) + FormatInput(g) + FormatInput(b);
        }

        private static string FormatInput(int p0)
        {
            if (p0 > 255)
            {
                return 255.ToString("X");
            }

            if (p0 < 0)
            {
                return AddPrecedingZero(0.ToString("X"));
            }

            if (p0 < 16)
            {
                return AddPrecedingZero(p0.ToString("X"));
            }

            return p0.ToString("X");
        }

        private static string AddPrecedingZero(string x)
        {
            return "0" + x;
        }
    }
}