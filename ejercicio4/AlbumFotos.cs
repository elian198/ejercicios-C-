using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class AlbumFotos
    {
        private int NumPaginas;

        public AlbumFotos()
        {
            NumPaginas = 16;
        }

        public AlbumFotos (int numeroPagina)
        {
            NumPaginas = numeroPagina;
        }

        public int GetNumeroPaginas()
        {
            return NumPaginas;      }
    }
}
