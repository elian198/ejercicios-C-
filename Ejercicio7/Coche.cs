using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Coche : IVehiculo
    {

        public int Gasolina { get; set; }
        

        public Coche(int gasolina)
        {
            Gasolina = gasolina;
        }

        public void Conducir(){
            if(Repostar(this.Gasolina)){ Console.WriteLine("Conduciendo"); }
        }

        public bool Repostar(int gasolina) {
            this.Gasolina = gasolina;
            if (this.Gasolina > 0) return true;
            return false;
        }
       
    }
}
