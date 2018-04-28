using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    using System.Text.RegularExpressions;

    public class Not_very_secure
    {
        public static bool Alphanumeric(string str)
        {
            return new Regex("^[a-zA-Z0-9]+$").Match(str).Success;
        }
    }
}