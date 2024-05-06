using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public class ListaEnlazada
    {
        public Paciente Inicio;



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

        public void AgregarDespuesDelSeleccionado(Paciente Nodo, Paciente paciente)
        {
            if (Inicio == null)
            {
                Inicio = Nodo;
            }
            else if(Inicio == paciente)
            {
                Paciente aux = Inicio.Siguiente;
                Inicio.Siguiente = Nodo;
                Nodo.Siguiente = aux;
            }
            else
            {
                Paciente actual = Inicio;

                while (actual != null)
                {
                    if (actual == paciente)
                    {
                        Paciente aux = paciente.Siguiente;
                        paciente.Siguiente = Nodo;
                        Nodo.Siguiente = aux;
                        return;
                    }
                    actual = actual.Siguiente;
                }
            }          
        }

        public bool EliminarPrimero()
        {
            if(Inicio == null)
            {
                return false;
            }    
            else
            {
                Paciente aux = Inicio.Siguiente;
                Inicio = aux;
                return true;
            }
        }

        public void EliminarSeleccionado(Paciente paciente)
        {
            if (Inicio == null)
            {
                return;
            }
            if (Inicio == paciente)
            {
                Inicio = Inicio.Siguiente;
                return;
            }

            Paciente actual = Inicio;

            while(actual.Siguiente != null)
            {
                if(actual.Siguiente == paciente)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return;
                }

                actual = actual.Siguiente;
            }         
        }

 
        public void ActualizarSeleccionado (Paciente pacienteActualizado)
        {
            if (Inicio == null)
            {
                return;
            }

            if(Inicio.Equals(pacienteActualizado))
            {
                Inicio = pacienteActualizado;
                return;
            }


            Paciente actual = Inicio;

            while (actual.Siguiente != null)
            {
                if(actual.Siguiente.Equals(pacienteActualizado))
                {
                    actual.Siguiente = pacienteActualizado;
                    return;
                }
                actual = actual.Siguiente;
            }

        }

        public List<Paciente> getPacientes()
        {
            List <Paciente> pacientes = new List<Paciente>();

            Paciente actual = Inicio;

            while (actual != null)
            {
                pacientes.Add(actual);
                actual = actual.Siguiente;
            }
            return pacientes;
        }
    }
}
