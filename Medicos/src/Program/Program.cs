using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           Paciente pacienteA =new Paciente("Claudio","5.629.514-8", "096546574") ;
           Doctor DoctorA = new Doctor("Marcelo", "Fisioterapeuta", "Hospital Americano" );
           DateTime fechaA = new DateTime(2033,3,12);
           AppointmentService ConsultaA = new AppointmentService(pacienteA, fechaA);
           DoctorA.AgregarConsulta(ConsultaA);
           DoctorA.ObtenerConsultas();

        }
    }
}
