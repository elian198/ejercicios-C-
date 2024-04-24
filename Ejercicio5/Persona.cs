using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Persona
    {
        public String Nombre { get; set; }

        public Persona(string nombre)
        {
            nombre = nombre;
        }

        public Persona()
        {
        }

        public override string ToString()
        {
            return "Mi nombre es " + Nombre;
        }

    }
}
