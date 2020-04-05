using System;
using System.Collections.Generic;
using System.Text;

namespace TagalogHelper.Domain.TranslateGroups
{
    public static class Food
    {
        public static string GetTranslation(string EnglishText)
        {
            return EnglishText switch
            {
                PhraseConstants.COFFEE => "Kape",
                PhraseConstants.COFFEE_TIME => "Oras na para magkape",
                PhraseConstants.IT_IS_TIME_FOR_COFFEE => "Oras na para magkape",
                PhraseConstants.BREAKFAST => "Agahan / Almusal",
                PhraseConstants.IT_IS_TIME_FOR_BREAKFAST => "Oras na para sa agahan / almusal",
                PhraseConstants.BREAKFAST_TIME => "Oras ng agahan / almusal",
                PhraseConstants.DID_YOU_HAVE_BREAKFAST => "Nag breakfast ka na",
                PhraseConstants.DID_YOU_EAT_BREAKFAST => "Kumain ka ba ng agahan / almusal",
                PhraseConstants.DID_YOU_DRINK_YOUR_COFFEE => "Nakainom ka ba ng kape mo",
                PhraseConstants.HAVE_YOU_HAD_COFFEE => "Nakainom ka ba ng kape mo",
                PhraseConstants.HAVE_YOU_HAD_YOUR_COFFEE => "Nakainom ka ba ng kape mo",
                PhraseConstants.DID_HAVE_YOUR_YOUR_COFFEE => "Nakainom ka ba ng kape mo",
                PhraseConstants.HAVE_YOU_EATEN_ALREADY => "kumain ka na ba",
                PhraseConstants.HAVE_YOU_EATEN => "kumain ka na ba",
                _ => "No Translation Found for " + EnglishText,
            };


        }
    }
}
