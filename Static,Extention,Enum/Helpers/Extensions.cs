using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Static_Extention_Enum.Helpers
{
    public static class Extensions
    {
        public static int StringCheck(this string str,string pattern)
        {
            return Regex.Matches(str, pattern).Count;
        }
    }
}
