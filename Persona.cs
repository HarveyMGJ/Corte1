using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1
{
    internal class Persona
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime fechadenacimiento { get; set; }
        public Persona(string nombres, string apellidos, DateTime fechadenacimiento)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Fechadenacimiento = fechadenacimiento;
        }
        public override string ToString()
        {
            return $"Nmbres} {apellidos}, Fecha De Nacimiento: {fechadenacimiento.ToShortDateString};
    }



    } }
