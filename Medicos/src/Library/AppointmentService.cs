using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public Paciente Paciente {get; set; }
        public DateTime Fecha {get; set; }
        public AppointmentService(Paciente paciente, DateTime fecha)
        {
            this.Paciente=paciente;
            this.Fecha=fecha;
        }   
     
        
                    
                    

                    
    }

}

