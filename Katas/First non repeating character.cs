namespace Katas
{
    using System.Linq;

    public class Kata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            var ret = s.GroupBy(z => char.ToLower(z)).FirstOrDefault(g => g.Count() == 1);
            return (ret != null) ? ret.First().ToString() : string.Empty;
        }
    }
}