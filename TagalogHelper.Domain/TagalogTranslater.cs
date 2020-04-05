using System;

namespace TagalogHelper.Domain
{
    public static class TranslateToTagalog
    {
        public static string GetTranslation(string EnglishText)
        {
            EnglishText = Utils.CleanUpText(EnglishText);

            return EnglishText switch
            {
                PhraseConstants.HELLO => FormalGreetings.GetTranslation(EnglishText),
                PhraseConstants.HOW_ARE_YOU => FormalGreetings.GetTranslation(EnglishText),
                _ => "No Translation Found for " + EnglishText,
            };
        }
        
}
}

