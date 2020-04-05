using System;
using System.Collections.Generic;
using System.Text;

namespace TagalogHelper.Domain
{
    public static class FormalGreetings
    {
        public static string GetTranslation(string EnglishText)
        {
            return EnglishText switch
            {
                PhraseConstants.HELLO => "Kamusta",
                PhraseConstants.HOW_ARE_YOU => "",
                _ => "",
            };


        }
    }
}
