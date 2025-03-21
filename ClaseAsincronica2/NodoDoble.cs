using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAsincronica2
{
    class NodoDoble
    {
        private int Dato;
        private NodoDoble Siguiente;
        private NodoDoble Anterior;

        public int dato
        {
            get { return Dato; }
            set { Dato = value; }
        }

        public NodoDoble siguiente
        {
            get { return Siguiente; }
            set { Siguiente = value; }
        }
        //
        public NodoDoble anterior
        {
            get { return Anterior; }
            set { Anterior = value; }
        }
    }
}

//commit