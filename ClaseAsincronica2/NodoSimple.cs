using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAsincronica2
{
    class NodoSimple
    {
        private int Dato;
        private NodoSimple Siguiente;

        public int dato
        {
            get { return Dato; }
            set { Dato = value; }
        }

        public NodoSimple siguiente
        {
            get { return Siguiente; }
            set { Siguiente = value; }
        }
    }
}
//
//commit