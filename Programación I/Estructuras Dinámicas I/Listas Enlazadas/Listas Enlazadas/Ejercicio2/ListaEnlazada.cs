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
            if(Inicio == null)
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

            if(actual != null)
            {
                alumnos.Add(actual);
                actual = actual.Siguiente;

            }
            return alumnos;
        }
    }
}
