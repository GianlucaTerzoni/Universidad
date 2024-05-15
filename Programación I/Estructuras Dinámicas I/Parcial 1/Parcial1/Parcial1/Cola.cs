using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    public class Cola
    {

        Impresora _inicio;

        public void Encolar(Impresora nuevoNodo)
        {
            if(_inicio == null)
            {
                _inicio = nuevoNodo;
            }
            else
            {
                Impresora aux = BuscarUltimoNodo(_inicio);
                aux.Siguiente = nuevoNodo;
            }
        }

        private Impresora BuscarUltimoNodo(Impresora Nodo)
        {
            if(Nodo.Siguiente == null)
            {
                return Nodo;
            }
            else
            {
                return BuscarUltimoNodo(Nodo.Siguiente);
            }
        }

        public void Desencolar()
        {
            _inicio = _inicio.Siguiente;
        }

        public Impresora Inicio
        {
            get
            {
                return _inicio;
            }
        }

        public bool Vacia()
        {
            if(_inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

    }
}
