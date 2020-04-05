using System;
using TagalogHelper.Domain;

namespace TagalogHelper.Console
{
    public class Program
    {
        private static bool RepeatQuestion;

        static void Main(string[] args)
        {
            RepeatQuestion = true;
            System.Console.ForegroundColor = ConsoleColor.Green;
            WriteHeader();
            
                while (RepeatQuestion)
                {
                    GetPhraseToTranslate();
                }
            
            
            System.Console.Read();
        }

        static void WriteHeader()
        {
            string str = "";

            System.Console.WriteLine("");
            System.Console.WriteLine(str.PadRight(30, '#'));
            System.Console.WriteLine("Welcome to Tagalog Helper");
            System.Console.WriteLine("Version 1.0");
            System.Console.WriteLine(str.PadRight(30, '#'));
            System.Console.WriteLine("");
            System.Console.WriteLine("Close Window to Exit");

        }

        static void GetPhraseToTranslate()
        {
            System.Console.WriteLine("");
            System.Console.Write("Enter english phrase to be translated to Tagalog:  ");
            
            string phraseToTranslate = System.Console.ReadLine();
            do
            {                
                if (phraseToTranslate == String.Empty)
                {
                    System.Console.WriteLine("");
                    System.Console.Write("Please enter text:");
                    System.Console.WriteLine("");
                }

            }
            while (phraseToTranslate == String.Empty);

            System.Console.WriteLine("Translation: " + TranslateToTagalog.GetTranslation(phraseToTranslate));
            System.Console.WriteLine("");            
        }
    }
}
