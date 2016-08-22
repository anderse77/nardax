using System;
using System.ComponentModel;

namespace Nardax
{
    public static class StringExtensions
    {
        //Klipp av en sträng från vänster.

        public static string TruncateLeftzzzzzzzzzzzzzzzzzzzzzzzz

        //Klipp av en sträng från höger.

        public static string TruncateRight(this string value, int maxLength)
        {
            if (value.Length < maxLength)
            {
                return value;
            }

            return value.Substring(0, maxLength);
        }
    }
}
