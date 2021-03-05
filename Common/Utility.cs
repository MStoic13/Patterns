using System;
using System.Linq;

namespace Common
{
    public static class Utility
    {
        public static string RemoveAllWhitespaces(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            return string.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
        }
    }
}
