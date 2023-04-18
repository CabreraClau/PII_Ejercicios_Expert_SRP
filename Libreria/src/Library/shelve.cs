using System;
using System.Collections.Generic;

namespace SRP
{

    public class Shelve
    {
        public int Id { get; set; } // Atributo para identificar la estantería de manera única
        public List<Libro> libros = new List<Libro>();
        public Shelve(int id)
            {
                this.Id = id;  
            }
        public void AgregarLibro(Libro libro)
            {
                libros.Add(libro);
            }

        public void ObtenerLibros()
        {
            Console.WriteLine("Los libros que se encuentran dentro de este estante son:");
            foreach (Libro libro in libros)
            {
                Console.WriteLine(libro.Title);
            }
        }
    }
}