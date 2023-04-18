using System;
using System.Collections.Generic;
namespace SRP
{
    
    public class Sector
    {
        public string SectorName {get; set;}
        public List<Shelve> estanterias = new List<Shelve>();

        public void AgregarEstanteria(Shelve estanteria)
        {
            estanterias.Add(estanteria);
        }

        public Sector(String sector)
        {
            this.SectorName = sector;
        }
        public void ObtenerEstantes()
            {
                Console.WriteLine($"las estanterias que se encuentran dentro de este sector son: {estanterias}") ;
            }
               
    
    }
}