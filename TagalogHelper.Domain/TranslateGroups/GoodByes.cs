using System;
using System.Collections.Generic;
using System.Text;

namespace TagalogHelper.Domain.TranslateGroups
{
    public static class GoodByes
    {
        public static string GetTranslation(string EnglishText)
        {
            return EnglishText switch
            {
                PhraseConstants.GOOD_NIGHT => "Magandang Gabi",  
                PhraseConstants.SEE_YOU_SOON => "Kita kits",
                PhraseConstants.SEE_YOU_LATER => "Kita kits",
                _ => "No Translation Found for " + EnglishText
            };


        }
    }
}
