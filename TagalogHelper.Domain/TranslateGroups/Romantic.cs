using System;
using System.Collections.Generic;
using System.Text;

namespace TagalogHelper.Domain.TranslateGroups
{
    public static class Romantic
    {
        public static string GetTranslation(string EnglishText)
        {
            return EnglishText switch
            {
                PhraseConstants.I_LOVE_YOU => "Mahal kita",
                _ => "No Translation Found for " + EnglishText,
            };

        }
    }
}
