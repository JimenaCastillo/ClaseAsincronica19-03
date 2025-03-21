using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClaseAsincronica2;

namespace AUTHTest
{
    [TestClass]
    public class ListaCircularSimpleTests//
    {
        [TestMethod]
        public void InsertarNodoFinal_ListaNoVacia()
        {
            var lista = new ListaCircularSimple();
            lista.InsertarNodoFinal(10); // (✔ Se agregó un parámetro)

            Assert.AreNotEqual("", lista.ToString(), "La lista no debería estar vacía después de insertar un nodo.");
        }

        [TestMethod]
        public void InsertarNodoInicio_ListaNoVacia()
        {
            var lista = new ListaCircularSimple();
            lista.InsertarNodoInicio(20); // (✔ Se agregó un parámetro)

            Assert.AreNotEqual("", lista.ToString(), "La lista no debería estar vacía después de insertar un nodo al inicio.");
        }

        [TestMethod]
        public void EliminaPrimerNodo_ListaNoVacia()
        {
            var lista = new ListaCircularSimple();
            lista.InsertarNodoFinal(30);
            lista.InsertarNodoFinal(40);

            int tamañoAntes = lista.ToString().Split(',').Length;  // (✔ Se cuenta la cantidad de nodos antes)
            lista.EliminaPrimerNodo();
            int tamañoDespues = lista.ToString().Split(',').Length;  // (✔ Se cuenta después de eliminar)

            Assert.AreEqual(tamañoAntes - 1, tamañoDespues, "El tamaño de la lista no se redujo correctamente.");
        }

        [TestMethod]
        public void EliminaUltimoNodo_ListaNoVacia()
        {
            var lista = new ListaCircularSimple();
            lista.InsertarNodoFinal(50);
            lista.InsertarNodoFinal(60);

            int tamañoAntes = lista.ToString().Split(',').Length;  // (✔ Se cuenta la cantidad de nodos antes)
            lista.EliminaUltimoNodo();
            int tamañoDespues = lista.ToString().Split(',').Length;  // (✔ Se cuenta después de eliminar)

            Assert.AreEqual(tamañoAntes - 1, tamañoDespues, "El tamaño de la lista no se redujo correctamente.");
        }
    }
}
