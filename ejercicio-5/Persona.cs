using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejercicio_5
{
     class Persona
    {
        protected string Nombre { get; set; }
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return "Hola! Mi nombre es " + Nombre;
        }

        ~Persona()
        {
            Nombre = string.Empty;
        }
    }

}

