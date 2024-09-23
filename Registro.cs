using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1
{
    internal class Registro
    {
        public class Registro
        {
            private Persona[] personas;
            private int contador;
            public Registro()
            {
                personas = new Persona[30];
                contador = 0;
            }
            public void AgregarPersona(Persona persona)
            {
                if (contador < 0)
                {
                    persona[contador] = persona;
                    contador++;
                    Console.WriteLine("Persona agregada correctamante");
                }
                {
                    else
                }
                Console.WriteLine("El registro está lleno, no se puede agregar más personas");
             }
        }
    }
}
