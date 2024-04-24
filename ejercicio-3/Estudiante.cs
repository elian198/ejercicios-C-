using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Estudiante : Persona
    {

        public Estudiante(int edad)
        {
            Edad = edad;
        }
        public void verdad()
        {
            Console.WriteLine("Mi edad es : " + Edad + " años");
        }

        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }
        public override void Saludar()
        {
            Console.WriteLine( "Hola desde estudiante");
        }


    }
}
