using System;
using System.Collections.Generic;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Libro book1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro book2 = new Libro("Pro C#","Troelsen","001-035");
            Sector A = new Sector("A");
            Sector B = new Sector("B");
            Shelve Estante1 = new Shelve(1);
            Shelve Estante2 = new Shelve(2);
            A.AgregarEstanteria(Estante1);
            A.AgregarEstanteria(Estante2);
            Estante1.AgregarLibro(book1);
            Estante1.ObtenerLibros();
            

            


           

        }
    }
}