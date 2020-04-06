using System;
using TagalogHelper.Domain;
using TagalogHelper.Domain.Data;

namespace TagalogHelper.Console
{
    public class Program
    {
        private static bool RepeatQuestion;
        private const int HeaderLineLength = 30;

        static void Main(string[] args)
        {

            WriteLoadData();
            if(!TagalogHelperService.LoadData())
            {
                System.Console.ReadLine();
            }
            else
            {
                System.Console.Clear();

                RepeatQuestion = true;
                System.Console.ForegroundColor = ConsoleColor.Green;
                WriteHeader();

                while (RepeatQuestion)
                {
                    GetPhraseToTranslate();
                }


                System.Console.Read();
            }

           
        }

        static void WriteLoadData()
        {
            System.Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("");            
            System.Console.WriteLine("Loading Data Please Wait.........");            
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

            System.Console.WriteLine("Translation: " + TagalogHelperService.GetSingleTranslation(phraseToTranslate));
            System.Console.WriteLine("");            
        }
    }
}
