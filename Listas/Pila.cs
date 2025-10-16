using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Pila
    {
        List<string> lista;
        int _tope;

        public Pila(int elementos)
        {
            lista = new List<string>();
            _tope = 0;
        }
        public void Agregar(string dato)
        {
            int max = lista.Count - 1;
            if (_tope > max)
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
                throw new Exception("Ya no hay elementos");
            }
            lista.RemoveAt(_tope - 1);
            _tope--;
        }
    }
}
