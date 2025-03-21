using System;
using System.Text;

namespace ClaseAsincronica2
{
    public class ListaCircularDoble
    {
        private NodoDoble primero;
        private NodoDoble ultimo;

        public ListaCircularDoble()
        {
            primero = null;
            ultimo = null;
        }

        public void InsertarNodoFinal(int valor) // Se modificó para recibir un valor en lugar de usar Console.ReadLine()
        {
            NodoDoble nuevo = new NodoDoble();
            nuevo.dato = valor;

            if (primero == null)//
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.siguiente = primero;
                primero.anterior = ultimo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;
                nuevo.siguiente = primero;
                primero.anterior = nuevo;
                ultimo = nuevo;
            }
        }

        public void InsertarNodoInicio(int valor) // Se modificó para recibir un valor en lugar de usar Console.ReadLine()
        {
            NodoDoble nuevo = new NodoDoble();
            nuevo.dato = valor;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.siguiente = primero;
                primero.anterior = ultimo;
            }
            else
            {
                nuevo.siguiente = primero;
                primero.anterior = nuevo;
                nuevo.anterior = ultimo;
                ultimo.siguiente = nuevo;
                primero = nuevo;
            }
        }

        public void EliminaPrimerNodo()
        {
            if (primero == null)
            {
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
                primero.anterior = ultimo;
                ultimo.siguiente = primero;
            }
        }

        public void EliminaUltimoNodo()
        {
            if (primero == null)
            {
                return;
            }

            if (primero == ultimo)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                ultimo = ultimo.anterior;
                ultimo.siguiente = primero;
                primero.anterior = ultimo;
            }
        }

        public int ObtenerTamano() // Método agregado para contar nodos en las pruebas
        {
            if (primero == null) return 0;

            int contador = 1;
            NodoDoble actual = primero;

            while (actual.siguiente != primero)
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
            NodoDoble actual = primero;

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
