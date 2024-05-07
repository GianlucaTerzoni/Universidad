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
using System.Xml.Linq;

namespace Ejercicio2
{
    internal partial class FormAgregarAntes : Form
    {

        private ListaEnlazada Lista;

        private ListBox lsbListaCompleta;
        public FormAgregarAntes(ListaEnlazada lista, Form1 form1)
        {
            InitializeComponent();
            Lista = lista;
            lsbListaCompleta = form1.lsbListaCompleta;
        }

        private void btnAceptarRegistro_Click(object sender, EventArgs e)
        {
            var selectedItem = (Alumno)lsbListaCompleta.SelectedItem;


            if (txtNombre.Text.Length > 1 && txtApellido.Text.Length > 1 && txtDNI.Text.Length > 1
                && txtFechaDeNacimiento.Text.Length > 1 && txtDireccion.Text.Length > 1 && txtTelefono.Text.Length > 1)
            {
                Alumno nuevoAlumno = new Alumno(txtNombre.Text, txtApellido.Text, Convert.ToDecimal(txtDNI.Text), Convert.ToDateTime(txtFechaDeNacimiento.Text), txtDireccion.Text, Convert.ToDecimal(txtTelefono.Text));



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
                if (DateTime.TryParse(txtFechaDeNacimiento.Text, out DateTime fechaNacimiento))
                {
                    nuevoAlumno.FechaDeNacimiento = fechaNacimiento;
                }
                else
                {
                    MessageBox.Show("La fecha ingresada no es válida. Por favor, intente nuevamente.");
                }

                if (decimal.TryParse(txtTelefono.Text, out decimal tel))
                {
                    nuevoAlumno.Telefono = tel;
                }
                else
                {
                    MessageBox.Show("El número telefónico ingresado no es correcto. Intente nuevamente.");
                }

                MessageBox.Show("El alumno se agregó correctamente");


                Lista.AgregarAntesDelSeleccionado(selectedItem, nuevoAlumno);


                Form1 form1 = (Form1)this.Owner;

                form1.MostrarLista();

                this.Close();
            }

        }
    }
    
}
