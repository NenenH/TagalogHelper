using System;
using TagalogHelper.Domain.TranslateGroups;

namespace TagalogHelper.Domain
{
    public static class TranslateToTagalog
    {
        public static string GetTranslation(string EnglishText)
        {

            //TODO: Move to data to Sqlite
            EnglishText = Utils.CleanUpText(EnglishText);

            return EnglishText switch
            {
                PhraseConstants.HELLO => FormalGreetings.GetTranslation(EnglishText),
                PhraseConstants.HOW_ARE_YOU => FormalGreetings.GetTranslation(EnglishText),
                PhraseConstants.HOW_ARE_YOU_DOING => FormalGreetings.GetTranslation(EnglishText),
                PhraseConstants.GOOD_MORNING => FormalGreetings.GetTranslation(EnglishText),
                PhraseConstants.GOOD_NIGHT => GoodByes.GetTranslation(EnglishText),
                PhraseConstants.SEE_YOU_LATER => GoodByes.GetTranslation(EnglishText),
                PhraseConstants.SEE_YOU_SOON => GoodByes.GetTranslation(EnglishText),
                PhraseConstants.I_AM_HEADING_OUT => GoodByes.GetTranslation(EnglishText),
                PhraseConstants.I_AM_LEAVING => GoodByes.GetTranslation(EnglishText),
                PhraseConstants.COFFEE => Food.GetTranslation(EnglishText),
                PhraseConstants.COFFEE_TIME => Food.GetTranslation(EnglishText),
                PhraseConstants.IT_IS_TIME_FOR_COFFEE => Food.GetTranslation(EnglishText),
                PhraseConstants.IT_IS_TIME_FOR_BREAKFAST => Food.GetTranslation(EnglishText),
                PhraseConstants.BREAKFAST => Food.GetTranslation(EnglishText),
                PhraseConstants.BREAKFAST_TIME => Food.GetTranslation(EnglishText),
                PhraseConstants.DID_YOU_EAT_BREAKFAST => Food.GetTranslation(EnglishText),
                PhraseConstants.DID_YOU_HAVE_BREAKFAST => Food.GetTranslation(EnglishText),
                PhraseConstants.HAVE_YOU_EATEN => Food.GetTranslation(EnglishText),
                PhraseConstants.HAVE_YOU_EATEN_ALREADY => Food.GetTranslation(EnglishText),
                PhraseConstants.I_LOVE_YOU => Romantic.GetTranslation(EnglishText),
                PhraseConstants.I_MISS_YOU => Romantic.GetTranslation(EnglishText),
                PhraseConstants.I_LOVE_YOU_TOO => Romantic.GetTranslation(EnglishText),
                PhraseConstants.YES_MY_LOVE => Romantic.GetTranslation(EnglishText),
                _ => "No Translation Found for " + EnglishText,
            };
        }
        
}
}

