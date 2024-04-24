using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Persona
    {

     public String Nombre { get; set;  }

        public Persona(String nombre)
        {
            Nombre = nombre;
        }

        public String ToString()
        {
            return "Hola! Mi nombre ea " + Nombre;
        }

        ~Persona()
        {
            Nombre = String.Empty;
        }
    }
}
