using System;
using System.Collections.Generic;

namespace Library
{
    public class Doctor
    {
        public string Name { get ; set; }
        public string Especializacion {get; set;  }
        public string LugarAtiende {get; set; }
        public List<AppointmentService> consultas = new List<AppointmentService>();
        public Doctor (string name, string especializacion, string Consultoría)
        {
            this.Name=name;
            this.Especializacion=especializacion;
            this.LugarAtiende=Consultoría;
        }

        public void AgregarConsulta(AppointmentService consulta)
            {
                consultas.Add(consulta);
            }

        public void ObtenerConsultas()
        {
            Console.WriteLine($"Esta es la lista de consultas que tiene registrada hasta ahora: ");
            foreach ( AppointmentService Consulta in consultas)
            {
                Console.WriteLine($"La consulta con el paciente {Consulta.Paciente.Name} en la fecha {Consulta.Fecha}");
            }
        }
        

    }
}