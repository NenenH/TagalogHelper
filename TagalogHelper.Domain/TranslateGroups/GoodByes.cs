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
                PhraseConstants.I_AM_LEAVING => "Lalabas nako",
                PhraseConstants.I_AM_HEADING_OUT => "Lalabas nako",
                PhraseConstants.I_WILL_GO_OUT => "Lalabas nako",
                _ => "No Translation Found for " + EnglishText
            };


        }
    }
}
