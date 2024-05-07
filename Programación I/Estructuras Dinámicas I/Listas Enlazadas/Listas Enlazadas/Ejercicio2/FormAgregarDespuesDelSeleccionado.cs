using System;
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
    internal partial class FormAgregarDespuesDelSeleccionado : Form
    {

        private ListaEnlazada Lista;

        private ListBox lsbListaCompleta;

        public FormAgregarDespuesDelSeleccionado(ListaEnlazada lista, Form1 form1)
        {
            InitializeComponent();
            Lista = lista;
            lsbListaCompleta = form1.lsbListaCompleta;
        }

        private void btnAceptarDespuesSeleccionado_Click(object sender, EventArgs e)
        {
                var selectedItem = (Alumno)lsbListaCompleta.SelectedItem; 


            if (txtName.Text.Length > 1 && txtLastName.Text.Length > 1 && txtID.Text.Length > 1
                && txtBirthday.Text.Length > 1 && txtAdress.Text.Length > 1 && txtPhone.Text.Length > 1)
            {
                Alumno nuevoAlumno = new Alumno(txtName.Text, txtLastName.Text, Convert.ToDecimal(txtID.Text), Convert.ToDateTime(txtBirthday.Text), txtAdress.Text, Convert.ToDecimal(txtPhone.Text));
                
                

                nuevoAlumno.Nombre = txtName.Text;
                nuevoAlumno.Apellido = txtLastName.Text;
                nuevoAlumno.Direccion = txtAdress.Text;


                if (decimal.TryParse(txtID.Text, out decimal dni))
                {
                    nuevoAlumno.Dni = dni;
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no es válido. Por favor, ingrese un número válido.");
                }
                if (DateTime.TryParse(txtBirthday.Text, out DateTime fechaNacimiento))
                {
                    nuevoAlumno.FechaDeNacimiento = fechaNacimiento;
                }
                else
                {
                    MessageBox.Show("La fecha ingresada no es válida. Por favor, intente nuevamente.");
                }

                if (decimal.TryParse(txtPhone.Text, out decimal tel))
                {
                    nuevoAlumno.Telefono = tel;
                }
                else
                {
                    MessageBox.Show("El número telefónico ingresado no es correcto. Intente nuevamente.");
                }

                MessageBox.Show("El alumno se agregó correctamente");

                
                Lista.AgregarDespuesDelSeleccionado(selectedItem, nuevoAlumno);


                Form1 form1 = (Form1)this.Owner;

                form1.MostrarLista();

                this.Close();
            }

        }
    }
}
