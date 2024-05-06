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
        public decimal Dni { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Direccion { get; set; }
        public decimal Telefono { get; set; }

        public Alumno Siguiente;

        public Alumno(string nombre, string apellido, decimal dni, DateTime fechaDeNacimiento, string direccion, decimal telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Dni = dni;
            FechaDeNacimiento = fechaDeNacimiento;

        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellido: {Apellido}, DNI: {Dni}, Fecha de Nacimiento: {FechaDeNacimiento}, Dirección: {Direccion}, Teléfono: {Telefono}";
        }
    }
}
