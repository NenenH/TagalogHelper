using System;
using System.Collections.Generic;
using System.Text;

namespace TagalogHelper.Domain
{
    public static class Utils
    {
        public static string CleanUpText(string textToClean)
        {
            if(String.IsNullOrEmpty(textToClean))
            {
                textToClean = "[No Input]";
            }
            else
            {
                textToClean = textToClean.Replace("?", "");
                textToClean = textToClean.Replace("!", "");
            }
            
            return textToClean.ToUpper().Trim();

        }
    }
}
