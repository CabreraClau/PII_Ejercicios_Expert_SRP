using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        
        public string Name { get ; set;  }
        public string Id { get ; set; }
        public string Edad {get; set; }
        public string Numero { get ; set ; }
        
        

        public Paciente (string name, string id,string numero)
        {
            this.Name=name;
            this.Id=id;
            this.Numero=numero; 
        }
    }
}