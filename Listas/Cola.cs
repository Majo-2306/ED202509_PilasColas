using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Cola
    {
        List<string> lista = new List<string>();
        int _inicio;
        int _final;

        public Cola(int elementos)
        {
            lista = new List<string>();
            _inicio = 0;
            _final = 0;
        }

        public void Agregar(string dato)
        {
            if (_final > lista.Count) 
            {
                throw new Exception("La cola se encuentra llena");
            }
            lista.Add(dato);
            _final++;
        }

        public string Imprimir()
        {
            string datos = string.Empty;
            for (int i = _inicio; i < lista.Count(); i++) 
            {
                Console.WriteLine(lista[i]);
            }
            return datos;
        }

        public void Eliminar() 
        {
            if (_final == 0 || _inicio == _final) 
            {
                throw new Exception("La cola esta vacia");
            }
            _inicio++;
        }

    }
}
