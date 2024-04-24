using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    class Profesor : Persona
    {
        public Profesor(string nombre) : base(nombre)
        {
            Nombre = nombre;
        }

        public void Explicar()
        {
            Console.WriteLine("Explicar");
        }


    }
}
