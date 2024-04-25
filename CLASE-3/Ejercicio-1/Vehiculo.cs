using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Vehiculo
    {

        protected String Marca, Modelo;

        public Vehiculo(String marca, String modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

         public  virtual void ImprimirDatos()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
        }
    }
}
