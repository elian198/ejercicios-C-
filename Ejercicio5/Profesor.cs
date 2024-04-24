
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Profesor : Persona
    {
        public Profesor(String nombre):base(nombre)
        {
            Nombre = nombre;
        }

        public void Explicar(){ Console.WriteLine("Estoy explicando"); }
       

    }

}
