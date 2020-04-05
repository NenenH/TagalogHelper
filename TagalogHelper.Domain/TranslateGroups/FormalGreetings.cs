using System;
using System.Collections.Generic;
using System.Text;

namespace TagalogHelper.Domain.TranslateGroups
{
    public static class FormalGreetings
    {
        public static string GetTranslation(string EnglishText)
        {
            return EnglishText switch
            {
                PhraseConstants.HELLO => "Kamusta",
                PhraseConstants.HOW_ARE_YOU => "Kamusta ka",
                PhraseConstants.HOW_ARE_YOU_DOING => "Kamusta ka",
                PhraseConstants.GOOD_MORNING => "Magandang Umaga",
                _ => "No Translation Found for " + EnglishText,
            };


        }
    }
}
