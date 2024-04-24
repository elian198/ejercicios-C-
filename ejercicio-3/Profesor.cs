using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Profesor : Persona
    {
        public Profesor(int edad)
        {
            Edad = edad;
        }
        public void Explicar(){ Console.WriteLine("Estoy explicando"); }
        public override void Saludar()  { Console.WriteLine("Hola desde Profesor");  }

    }

}
