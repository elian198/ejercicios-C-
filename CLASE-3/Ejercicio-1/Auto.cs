using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Auto : Vehiculo
    {
        public Auto(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override void ImprimirDatos()
        {
            Console.WriteLine("Vehiculo: Auto ");
            base.ImprimirDatos();
        }
    }
}
