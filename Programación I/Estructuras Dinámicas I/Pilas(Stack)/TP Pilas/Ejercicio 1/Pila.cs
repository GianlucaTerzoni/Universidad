using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Pila
    {

        Contenedor _tope;

        public Contenedor Tope()
        {
            return _tope;
        }


        public void Push(Contenedor nuevoContenedor)
        {
            if(_tope == null)
            {
                _tope = nuevoContenedor;
            }
            else
            {
                Contenedor aux = _tope;
                _tope = nuevoContenedor;
                _tope.Siguiente = aux;                
            }
        }
        public void Pop()
        {
            if(_tope != null)
            {
                _tope = _tope.Siguiente;
            }
        }
    }
}
