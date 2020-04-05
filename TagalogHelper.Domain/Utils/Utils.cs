using System;
using System.Collections.Generic;
using System.Text;

namespace TagalogHelper.Domain
{
    public static class Utils
    {
        public static string CleanUpText(string textToClean)
        {
            textToClean = textToClean.Replace("?", "");
            textToClean = textToClean.Replace("!", "");

            return textToClean.ToUpper().Trim();

        }
    }
}
