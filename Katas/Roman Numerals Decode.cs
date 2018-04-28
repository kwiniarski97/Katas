namespace Katas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RomanDecode
    {
        public static int Solution(string roman)
        {
            var dict = GetRomanNumbers();
            var array = roman.SplitInParts(1);
            int number = 0;
            for (int i = 0; i < array.Count(); i++)
            {
                if (i + 1 < array.Count())
                {
                    var combined = array[i] + array[i + 1];

                    if (dict.ContainsKey(combined))
                    {
                        number += dict[combined];
                        i++;
                        continue;
                    }
                }

                number += dict[array[i]];
            }

            return number;
        }

        public static Dictionary<string, int> GetRomanNumbers()
        {
            var romanNumbers = new Dictionary<string, int> { };
            romanNumbers.Add("I", 1);
            romanNumbers.Add("IV", 4);
            romanNumbers.Add("V", 5);
            romanNumbers.Add("IX", 9);
            romanNumbers.Add("X", 10);
            romanNumbers.Add("XL", 40);
            romanNumbers.Add("L", 50);
            romanNumbers.Add("XC", 90);
            romanNumbers.Add("C", 100);
            romanNumbers.Add("CD", 400);
            romanNumbers.Add("D", 500);
            romanNumbers.Add("CM", 900);
            romanNumbers.Add("M", 1000);
            return romanNumbers;
        }
    }

    public static class StringExtensions
    {
        public static List<string> SplitInParts(this string s, int partLength)
        {
            var list = new List<string>();
            if (s == null)
                throw new ArgumentNullException("s");
            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", "partLength");

            for (var i = 0; i < s.Length; i += partLength)
                list.Add(s.Substring(i, Math.Min(partLength, s.Length - i)));

            return list;
        }
    }
}