using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClaseAsincronica2;

namespace AuthTest2
{//
    [TestClass]
    public class ListaCircularDobleTests
    {
        [TestMethod]
        public void InsertarNodoFinal_ListaNoVacia()
        {
            var lista = new ListaCircularDoble();
            lista.InsertarNodoFinal(10);

            int tamaño = lista.ObtenerTamano();
            Assert.AreEqual(1, tamaño, "El tamaño de la lista debería ser 1 después de insertar un nodo.");
        }

        [TestMethod]
        public void InsertarNodoInicio_ListaNoVacia()
        {
            var lista = new ListaCircularDoble();
            lista.InsertarNodoInicio(20);

            int tamaño = lista.ObtenerTamano();
            Assert.AreEqual(1, tamaño, "El tamaño de la lista debería ser 1 después de insertar un nodo al inicio.");
        }

        [TestMethod]
        public void EliminaPrimerNodo_DeListaNoVacia()
        {
            var lista = new ListaCircularDoble();
            lista.InsertarNodoFinal(30);
            lista.InsertarNodoFinal(40);

            int tamañoAntes = lista.ObtenerTamano();
            lista.EliminaPrimerNodo();
            int tamañoDespues = lista.ObtenerTamano();

            Assert.AreEqual(tamañoAntes - 1, tamañoDespues, "El tamaño de la lista no se redujo correctamente.");
        }

        [TestMethod]
        public void EliminaUltimoNodo_DeListaNoVacia()
        {
            var lista = new ListaCircularDoble();
            lista.InsertarNodoFinal(50);
            lista.InsertarNodoFinal(60);

            int tamañoAntes = lista.ObtenerTamano();
            lista.EliminaUltimoNodo();
            int tamañoDespues = lista.ObtenerTamano();

            Assert.AreEqual(tamañoAntes - 1, tamañoDespues, "El tamaño de la lista no se redujo correctamente.");
        }
    }
}
