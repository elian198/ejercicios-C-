using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
     class Estudiante : Persona
    {
        public Estudiante(string nombre) : base(nombre)
        {
            Nombre = nombre;
        }

        public void Estudiar()
        {
            Console.WriteLine("Estudiar");
        }
    
    }
}
