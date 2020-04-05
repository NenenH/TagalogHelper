using System;
using TagalogHelper.Domain;

namespace TagalogHelper.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            WriteHeader();
            do
            {
                while (!System.Console.KeyAvailable)
                {
                    GetPhraseToTranslate();
                }
            } while (System.Console.ReadKey(true).Key != ConsoleKey.Escape);
            

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
            System.Console.WriteLine("Press ESC to exit");

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
