using System;

namespace SRP
{
    public class Book
    {

        public string Title { get; }
        public string Author { get; }
        public string Code { get; }

        public Location Place { get; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
        /*
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        Esta clase se extrajo debido a que se creo una clase con la especialización de esta responsabilidad
        */
    }
}
