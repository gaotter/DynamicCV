using System;
using System.Collections.Generic;
using System.Text;

namespace Knowit.Amende.Helpers.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// return the current string or empty string if string is null. To make sure you don't 
        /// get an invalid string.
        /// </summary>
        /// <param name="s">string to verify</param>
        /// <returns></returns>
        public static string CurrentStringOrEmpty(this string s)
        {
            return s ?? string.Empty;
        }
    }
}
