using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            book1.Place= new Location("A","7","Mullin");
            book2.Place= new Location("B","3","Central");

    
            Console.WriteLine($"El libro se encuentra en el edificio {book1.Place.Building} en la sección {book1.Place.Section} en la estanteria {book1.Place.Shelf} ");
        }
    }
}