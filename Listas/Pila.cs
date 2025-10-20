using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Pila
    {
        List<string> lista = new List<string>();//aca inicializamos lo que es la lista y donde quiero que reciba elementos del tipo string
        int _tope;//aca estamos iniciando tope que quiero que cheque en que indice estamos por eso se le dio el int

        public Pila(int elementos)
        {
            lista = new List<string>();
            _tope = 0;
        }
        public void Agregar(string dato)
        {
            
            if (_tope > lista.Count)
            {
                throw new Exception("Ya no hay espacio");
            }
            lista.Add(dato);
            _tope++;
        }

        public string Imprimir()
        {
            string datos = string.Empty;
            int max = lista.Count();
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(lista[i]);
            }
            return datos;
        }

        public void Eliminar()
        {
            if (_tope <= 0)
            {
                throw new Exception("La pila esta vacia");
            }
            lista.RemoveAt(_tope - 1);
            _tope--;
        }
    }
}
