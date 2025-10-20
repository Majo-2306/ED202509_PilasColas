using System.Linq.Expressions;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pila pila = new Pila(5);
                pila.Agregar("A");
                pila.Agregar("B");
                pila.Agregar("C");
                pila.Agregar("D");
                pila.Agregar("E");

                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Cola cola = new Cola(5);
                cola.Agregar("A");
                cola.Agregar("B");
                cola.Agregar("C");
                cola.Agregar("D");
                cola.Agregar("E");

                Console.WriteLine(cola.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine("Eliminando un elemento");
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
            
        }
    }
}
