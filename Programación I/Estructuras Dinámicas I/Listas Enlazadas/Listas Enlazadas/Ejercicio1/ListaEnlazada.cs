using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class ListaEnlazada
    {
        public Paciente Inicio;


        public void AgregarAlFinal()
        {

        }

        public void AgregarAlPrincipio(Paciente Nodo)
        {
            if (Inicio == null)
            {
                Inicio = Nodo;      

            }
            else 
            {
                Paciente aux = Inicio;  
                Inicio = Nodo;  
                Nodo.Siguiente = aux; 
                
            }
        }

    }
}
