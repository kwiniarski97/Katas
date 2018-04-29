namespace Katas
{
    using System.Collections.Generic;
    using System.Text;

    public class Convert_PascalCase_string_into_snake_case
    {
        public static string ToUnderscore(int str)
        {
            return str.ToString();
        }

        public static string ToUnderscore(string str)
        {
            var output = new StringBuilder();
            foreach (var ch in str.ToCharArray())
            {
                if (char.ToUpper(ch) == ch && output.Length > 0 && !char.IsDigit(ch))
                {
                    output.Append('_');
                }

                output.Append(char.ToLower(ch));
            }

            return output.ToString();
        }
    }
}