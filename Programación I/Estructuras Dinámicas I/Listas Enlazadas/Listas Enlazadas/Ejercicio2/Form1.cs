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
            CfgDataGridView();
            MostrarLista();
        }

        private void CfgDataGridView()
        {
            dgv1.AutoGenerateColumns = false;
            dgv1.Columns.Add("Nombre", "Nombre");
            dgv1.Columns.Add("Apellido", "Apellido");
            dgv1.Columns.Add("Dni", "DNI");
            dgv1.Columns.Add("FechaDeNacimiento", "Fecha de Nacimiento");
            dgv1.Columns.Add("Direccion", "Dirección");
            dgv1.Columns.Add("Telefono", "Teléfono");
        }

        public void AgregarItemALaLista(Alumno Nodo)
        {

            if(Nodo != null)
            {
                dgv1.Rows.Add(Nodo.Nombre, Nodo.Apellido, Nodo.Dni, Nodo.Direccion, Nodo.FechaDeNacimiento, Nodo.Telefono);
                AgregarItemALaLista(Nodo.Siguiente);
            }

        }

        public void MostrarLista()
        {

            dgv1.Rows.Clear();

            var alumnos = Lista.GetAlumnos();

            foreach (var alumno in alumnos)
            {
                dgv1.Rows.Add(alumno.Nombre, alumno.Apellido, alumno.Dni, alumno.FechaDeNacimiento, alumno.Direccion, alumno.Telefono);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarAlumno registrar = new FormRegistrarAlumno(Lista);
            registrar.ShowDialog(this);
            MostrarLista();
        }
    }
}
