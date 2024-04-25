using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Biblioteca : IBiblioteca
    {

        public void ObtenerLibros()
        {
            foreach (String libro in new List<String> { "libro 1", "libro 2", "libro 3", "libro 4" })
            {
                Console.Write(libro + ",");
            }
        }
    }
}
