using System;
using System.Text;

namespace ClaseAsincronica2
{
    public class ListaCircularSimple
    {
        private NodoSimple primero;
        private NodoSimple ultimo;

        public ListaCircularSimple()
        {
            primero = null;
            ultimo = null;
        }

        public void InsertarNodoFinal(int valor) // (✔ Se agregó un parámetro para recibir el dato)
        {
            NodoSimple nuevo = new NodoSimple();
            nuevo.dato = valor; // (✔ Ahora el valor se pasa como parámetro en lugar de leer desde la consola)

            if (primero == null)//
            {
                primero = nuevo;
                primero.siguiente = primero;
                ultimo = primero;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.siguiente = primero;
                ultimo = nuevo;
            }
        }

        public void InsertarNodoInicio(int valor) // (✔ Se agregó un parámetro)
        {
            NodoSimple nuevo = new NodoSimple();
            nuevo.dato = valor;  // (✔ Se asigna directamente)

            if (primero == null)
            {
                primero = nuevo;
                primero.siguiente = primero;
                ultimo = primero;
            }
            else
            {
                nuevo.siguiente = primero;
                primero = nuevo;
                ultimo.siguiente = primero;
            }
        }

        public void InsertarNodoEnPosicion(int valor, int posicion) // (✔ Se agregaron parámetros)
        {
            NodoSimple nuevo = new NodoSimple();
            nuevo.dato = valor;  // (✔ Se asigna directamente)

            if (primero == null)
            {
                primero = nuevo;
                primero.siguiente = primero;
                ultimo = primero;
                return;
            }

            NodoSimple actual = primero;
            int contador = 1;

            // Buscar la posición anterior a la deseada
            while (contador < posicion - 1 && actual.siguiente != primero)
            {
                actual = actual.siguiente;
                contador++;
            }

            nuevo.siguiente = actual.siguiente;
            actual.siguiente = nuevo;

            if (actual == ultimo)
            {
                ultimo = nuevo;
            }
        }

        public void EliminaPrimerNodo()
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (primero == ultimo)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                primero = primero.siguiente;
                ultimo.siguiente = primero;
            }
        }

        public void EliminaUltimoNodo()
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (primero == ultimo)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                NodoSimple actual = primero;
                while (actual.siguiente != ultimo)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = primero;
                ultimo = actual;
            }
        }

        public void EliminaPosicionNodo(int posicion) // (✔ Se agregó un parámetro en lugar de Console.ReadLine())
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (posicion <= 1)
            {
                EliminaPrimerNodo();
                return;
            }

            NodoSimple actual = primero;
            NodoSimple anterior = null;
            int contador = 1;

            while (contador < posicion && actual.siguiente != primero)
            {
                anterior = actual;
                actual = actual.siguiente;
                contador++;
            }

            if (contador == posicion)
            {
                anterior.siguiente = actual.siguiente;

                if (actual == ultimo)
                {
                    ultimo = anterior;
                }
            }
            else
            {
                Console.WriteLine("La posición no es válida.");
            }
        }

        public int ObtenerTamano()
        {
            if (primero == null)
            {
                return 0;
            }

            int contador = 1;
            NodoSimple actual = primero;

            while (actual.siguiente != primero) // (✔ Se corrigió la condición infinita)
            {
                actual = actual.siguiente;
                contador++;
            }

            return contador;
        }

        public override string ToString()
        {
            if (primero == null)
            {
                return "";
            }

            StringBuilder resultado = new StringBuilder();
            NodoSimple actual = primero;

            do
            {
                resultado.Append(actual.dato);
                if (actual.siguiente != primero)
                {
                    resultado.Append(", ");
                }
                actual = actual.siguiente;
            } while (actual != primero);

            return resultado.ToString();
        }
    }
}
