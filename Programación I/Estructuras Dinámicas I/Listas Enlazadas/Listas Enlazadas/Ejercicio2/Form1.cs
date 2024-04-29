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


    public partial class Form1 : Form
    {
        ListaEnlazada Lista = new ListaEnlazada();

        public Form1()
        {
            InitializeComponent();

            MostrarLista();
        }

        public void AgregarItemALaLista(Alumno Nodo)
        {
            if (Nodo != null)
            {
                lsbListaCompleta.Items.Add(Nodo);
                AgregarItemALaLista(Nodo.Siguiente);
            }
        }

        public void MostrarLista()
        {
            lsbListaCompleta.Items.Clear();
            var alumnos = Lista.GetAlumnos();

            foreach (var alumno in alumnos)
            {
                string infoAlumno = $"Nombre: {alumno.Nombre}, Apellido: {alumno.Apellido}, DNI: {alumno.Dni}, Fecha de Nacimiento: {alumno.FechaDeNacimiento}, Dirección: {alumno.Direccion}, Teléfono: {alumno.Telefono}";
                lsbListaCompleta.Items.Add(infoAlumno);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            FormRegistrarAlumno registrar = new FormRegistrarAlumno(Lista);
            registrar.ShowDialog(this);
            MostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (dgv1.CurrentRow != null)
            {
                Alumno seleccionado = (Alumno)dgv1.CurrentRow.DataBoundItem;
                Lista.EliminarAlumno(seleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar el Alumno que desea eliminar.");
            }
         
        }
    }
}
