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
                _ => "No Translation Found for " + EnglishText
            };


        }
    }
}
