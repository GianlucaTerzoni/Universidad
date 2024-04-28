using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    internal partial class FormRegistrarAlumno : Form
    {
        //ListaEnlazada Lista = new ListaEnlazada();
        private ListaEnlazada Lista;
        public FormRegistrarAlumno(ListaEnlazada lista)
        {
            InitializeComponent();
            Lista = lista;
        }

        private void btnAceptarRegistro_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Length > 1 && txtApellido.Text.Length > 1 && txtDNI.Text.Length > 1
                && txtFechaDeNacimiento.Text.Length > 1 && txtDireccion.Text.Length > 1 && txtTelefono.Text.Length > 1)
            {
                Alumno nuevoAlumno = new Alumno();

                nuevoAlumno.Nombre = txtNombre.Text;
                nuevoAlumno.Apellido = txtApellido.Text;
                nuevoAlumno.Direccion = txtDireccion.Text;
                if (decimal.TryParse(txtDNI.Text, out decimal dni))
                {
                    nuevoAlumno.Dni = dni;
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no es válido. Por favor, ingrese un número válido.");
                }
                if(DateTime.TryParse(txtFechaDeNacimiento.Text, out DateTime fechaNacimiento))
                {
                    nuevoAlumno.FechaDeNacimiento = fechaNacimiento;
                }
                else
                {
                    MessageBox.Show("La fecha ingresada no es válida. Por favor, intente nuevamente.");
                }

                if(decimal.TryParse(txtTelefono.Text, out decimal tel))
                {
                    nuevoAlumno.Telefono = tel;
                }
                else
                {
                    MessageBox.Show("El número telefónico ingresado no es correcto. Intente nuevamente.");
                }

                MessageBox.Show("El alumno se agregó exitosamente.");


            Lista.RegistrarAlumno(nuevoAlumno);

            
            Form1 form1 = (Form1)this.Owner;
            
            form1.MostrarLista();

            this.Close();
            }

        }
    }
}


