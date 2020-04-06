using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using TagalogHelper.Domain.Enums;

namespace TagalogHelper.Domain.Data
{
    public static class TagalogHelperService
    {
       
        public static bool LoadData()
        {
            ResetData();

           string path = 
           Assembly.GetExecutingAssembly().Location.Replace("TagalogHelper.Domain.dll", "")+
           @"\Data\TranslationData.txt";

            System.IO.StreamReader file =
            new System.IO.StreamReader(path);
            
            string line;
            TranslationTable data;
            using var context = new TagalogHelperContext();

            while ((line = file.ReadLine()) != null)
            {
                string[] columnData = line.Split(';');
                  
                try
                {
                    data = new TranslationTable
                    {
                        EnglishText = columnData[1],
                        TagalogText = columnData[2]
                    };

                    switch (columnData[0])
                    {
                        case "0":
                            data.TranslationGroupTypeId = TranslationTypes.Fragments;
                            break;
                        case "1":
                            data.TranslationGroupTypeId = TranslationTypes.Greetings;
                            break;
                        case "2":
                            data.TranslationGroupTypeId = TranslationTypes.Goodbyes;
                            break;
                        case "3":
                            data.TranslationGroupTypeId = TranslationTypes.Food;
                            break;
                        case "4":
                            data.TranslationGroupTypeId = TranslationTypes.Romantic;
                            break;
                        case "99":
                            data.TranslationGroupTypeId = TranslationTypes.Other;
                            break;
                    }

                    var entity = context.Translations.Add(data);
                    entity.State = EntityState.Added;
                }
                catch
                {
                    Console.Write("Unable to read line: [" + line+"]");
                    return false;
                }
         }

            context.SaveChanges();

                return true;
            }
       

               

        public static string GetSingleTranslation(string EnglishText)
        {
            EnglishText = Utils.CleanUpText(EnglishText);

            using var context = new TagalogHelperContext();

            var data = context.Translations.Where(x => x.EnglishText==EnglishText).ToList();

            foreach (var translation in data)
            {
                if(translation.EnglishText==EnglishText)
                {
                    return translation.TagalogText;
                }                               
            }

            return "No translation found.";
          
                                      
        }

        public static void GetAll()
        {            

            using var context = new TagalogHelperContext();
            if (context.Translations.Any())
            {
                var data = context.Translations.ToList();
                foreach (var translation in data)
                {
                    Console.WriteLine(translation.TagalogText);
                }
            }
            else
            {
                Console.WriteLine("No translations found");
            }
        }

        public static void ResetData()
        {
            using var context = new TagalogHelperContext();
            if (context.Translations.Any())
            {
                var data = context.Translations.ToList();
                foreach (var translation in data)
                {
                    context.Translations.Remove(translation);
                }

                context.SaveChanges();

            }
        }
    }

}
