using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Fifo
{
    class ClaseBase
    {

        private int dato;
        public int Dato { get { return dato; } set { dato = value; } }

        private ClaseBase siguiente;
        public ClaseBase Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public ClaseBase (int dato)
        {
            this.dato = dato;
        }
    }
}
