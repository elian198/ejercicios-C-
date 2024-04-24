using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_clase_2
{
    
    public class Persona
    {
        public String Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return "Mi nombre es : " + Nombre.ToString();
        }

    }

}
