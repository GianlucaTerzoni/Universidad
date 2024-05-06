using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class ListaEnlazada
    {

        public Alumno Inicio;


        public void RegistrarAlumno(Alumno nuevoAlumno)
        {
            if (Inicio == null)
            {
                Inicio = nuevoAlumno;
            }
            else
            {
                Alumno aux = Inicio;
                Inicio = nuevoAlumno;
                nuevoAlumno.Siguiente = aux;
            }
        }

        public List<Alumno> GetAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            Alumno actual = Inicio;

            while (actual != null)
            {
                alumnos.Add(actual);
                actual = actual.Siguiente;
            }
            return alumnos;
        }

        public void EliminarAlumno(Alumno alumno)
        {
            if (Inicio == null)
            {
                return; 
            }

            if (Inicio == alumno)
            {
                Inicio = Inicio.Siguiente; 
                return;
            }

            Alumno actual = Inicio;

            while (actual.Siguiente != null)
            {
                if (actual.Siguiente == alumno)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente; 
                    return;
                }

                actual = actual.Siguiente;
            }
        }

        public void ActualizarInfoAlumno(Alumno alumnoActualizado)
        {
            if(Inicio == null)
            {
                return;
            }

            if (Inicio.Equals(alumnoActualizado))
            {
                Inicio =  alumnoActualizado;
                return;
            }

            Alumno actual = Inicio;

            while(actual.Siguiente != null)
            {
                if (actual.Siguiente.Equals(alumnoActualizado))
                {
                    actual.Siguiente = alumnoActualizado;
                }
                actual = actual.Siguiente;
            }

        }
    }
}
