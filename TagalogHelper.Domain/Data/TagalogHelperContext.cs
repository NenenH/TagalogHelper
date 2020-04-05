using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TagalogHelper.Domain.Enums;

namespace TagalogHelper.Domain.Data
{
    public class TagalogHelperContext : DbContext
    {
        public TagalogHelperContext()
        {
            IntializeDB();
        }

        private void IntializeDB()
        {
            //Create the database if it does not exist
            this.Database.EnsureCreated();            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Filename=./TagalogHelperDB.sqlite");
        }

        public DbSet<TranslationTable> Translations { get; set; }
    }


    public class TranslationTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TranslationId { get; set; }
        public TranslationTypes TranslationGroupTypeId { get; set; }        
        public string EnglishText { get; set; }
        public string TagalogText { get; set; }      
    }
   
}
