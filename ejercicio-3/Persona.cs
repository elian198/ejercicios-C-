using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Persona
    {
        public int Edad;
        public virtual void Saludar() { Console.WriteLine("HOLA"); }
        public virtual void SetEdad(int edad){  Edad = edad; }
    }
}
