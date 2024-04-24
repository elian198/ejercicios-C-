using ejercicio_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Estudiante : Persona
    {

        public Estudiante(String nombre):base(nombre)
        {
            Nombre = nombre;
        }
    
        
       
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }
       

    }
}
