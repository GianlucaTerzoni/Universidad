using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Dni {  get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Direccion {  get; set; }
        public decimal Telefono { get; set; }

        public Alumno Siguiente;


    }
}
