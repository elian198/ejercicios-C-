using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal interface IVehiculo
    {

        public void Conducir() { }
        public Boolean Repostar(int gasolina);
    }
}
