using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Fifo
{
    class Colas
    {

        ClaseBase inicio = null;
        public void agrega(ClaseBase nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            } else
            {
                agregar(nuevo, inicio);
            }
        }

        private void agregar(ClaseBase nuevo, ClaseBase quien)
        {
            if (quien.Siguiente != null)
            {
                agregar(nuevo, quien.Siguiente);
            }
            else
                quien.Siguiente = nuevo;
        }




        public int ver()
        {
            if(inicio == null)
            {
                return 0;
            }else
                return inicio.Dato;
        }

        public int contador()
        {
            int i = 0;
            if (inicio != null)
            {
                ClaseBase temp = inicio;
                while (temp != null)
                {
                    i++;
                    temp = temp.Siguiente;
                }
            }
            return i;
        }

        public ClaseBase desencolar ()
        {
            ClaseBase temp;
            if(inicio.Siguiente != null)
            {
                temp = inicio;
                inicio = inicio.Siguiente;
                return inicio;
            }
            else
            {
                temp = inicio;
                inicio = null;
                return inicio;
            }
        }
    }
}
