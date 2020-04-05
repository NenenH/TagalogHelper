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
                PhraseConstants.I_MISS_YOU => "Na - miss kita",
                PhraseConstants.I_LOVE_YOU_TOO => "Mahal din kita",
                PhraseConstants.YES_MY_LOVE => "Oo mahal ko",
                  _ => "No Translation Found for " + EnglishText,
            };

        }
    }
}
